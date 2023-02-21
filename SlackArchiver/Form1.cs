using SlackNet;
using SlackNet.WebApi;
using System.ComponentModel;
using System.Configuration;

namespace SlackArchiver
{
    public partial class Form1 : Form
    {

        private static ISlackApiClient _api;

        public Form1()
        {


            InitializeComponent();

        }
        dd
        private void Form1_Load(object sender, EventArgs e)
        {
            var token = ConfigurationManager.AppSettings["token"];

            gChannels.AutoGenerateColumns = false;

            _api = new SlackServiceBuilder()
               .UseApiToken(token)
               .GetApiClient();


            btnArchive.Enabled = false;
            btnLoad.Enabled = true;

        }

        private async void Archive()
        {
            btnLoad.Enabled = false;
            btnArchive.Enabled = false;

            string channelCount = "0";
            string cursor = " ";

            textFound.Text = "0";
            textProcessing.Text = "0 of 0";


            List<Conversation> channels = new List<Conversation>();
            List<ConversationType> conversationTypes = new List<ConversationType>
            {
                ConversationType.PublicChannel,
                ConversationType.PrivateChannel
            };


            BindingList<GridChannel> gridChannelList = new BindingList<GridChannel>();

            ConversationListResponse response;
            response = await _api.Conversations.List(excludeArchived: true, limit: 200, types: conversationTypes);



            while (cursor != "")
            {
                cursor = response.ResponseMetadata.NextCursor;
                response = await _api.Conversations.List(excludeArchived: true, limit: 200, types: conversationTypes, cursor: response.ResponseMetadata.NextCursor);
                channels.AddRange(response.Channels);
            }



            channelCount = channels.Count.ToString();
            textFound.Text = channelCount; //TODO bind to property


            var processed = 0;
            var found = 0;

            gChannels.DataSource = gridChannelList;

            foreach (var channel in channels)
            {
                processed++;
                textProcessing.Text = processed.ToString() + " of " + channelCount;

                var historyResponse = await _api.Conversations.History(channel.Id, limit: 1);
                var lastMessage = historyResponse.Messages.FirstOrDefault();

                if (historyResponse.Messages.Count == 0 || LastMessageIsTooOld(lastMessage))
                {
                    found++;

                    var lastMessageAge = lastMessage != null ? DateTime.Now.Subtract(lastMessage.Timestamp).Days : -1;
                    
                    var privateStatus = channel.IsPrivate ? "Private" : "Public";
                    System.Diagnostics.Debug.WriteLine("found one: " + privateStatus + "_" + channel.Name);

                    gridChannelList.Add(new GridChannel(privateStatus, channel.Name, lastMessageAge, channel.Id));

                }

                textFound.Text = found.ToString();
            }

            btnLoad.Enabled = true;
            btnArchive.Enabled = true;

        }

        private bool LastMessageIsTooOld(SlackNet.Events.MessageEvent? message)
        {
            if (message == null || message.Timestamp < DateTime.Now.AddMonths(-9))
            {
                return true;
            }
            return false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Archive();
        }

        private async void btnArchive_Click(object sender, EventArgs e)
        {
            btnArchive.Enabled = false;

            foreach (DataGridViewRow selectedChannel in gChannels.SelectedRows)
            {
                try
                {
                    var channel = (GridChannel)selectedChannel.DataBoundItem;
                    await _api.Conversations.Archive(channel.Id);
                    gChannels.Rows.Remove(selectedChannel);
                }
                catch
                {
                    // TODO actualy error handling would be nice
                }
                
            }

            btnArchive.Enabled = true;
        }

        private record class GridChannel(string Type, string Name, int Age, string Id);

        private string ChannelCount
        {
            get { return ChannelCount; } 
            set { ChannelCount = value;}
        }
    }

}
