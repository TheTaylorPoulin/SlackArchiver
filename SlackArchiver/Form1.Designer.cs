namespace SlackArchiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textFound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProcessing = new System.Windows.Forms.TextBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.gChannels = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 414);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Found";
            // 
            // textFound
            // 
            this.textFound.Location = new System.Drawing.Point(79, 12);
            this.textFound.Name = "textFound";
            this.textFound.Size = new System.Drawing.Size(73, 23);
            this.textFound.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Processing";
            // 
            // textProcessing
            // 
            this.textProcessing.Location = new System.Drawing.Point(79, 52);
            this.textProcessing.Name = "textProcessing";
            this.textProcessing.Size = new System.Drawing.Size(73, 23);
            this.textProcessing.TabIndex = 4;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(172, 414);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(322, 23);
            this.btnArchive.TabIndex = 6;
            this.btnArchive.Text = "Archive Selected";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // gChannels
            // 
            this.gChannels.AllowUserToAddRows = false;
            this.gChannels.AllowUserToDeleteRows = false;
            this.gChannels.AllowUserToResizeColumns = false;
            this.gChannels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gChannels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.nName,
            this.Age});
            this.gChannels.Location = new System.Drawing.Point(172, 12);
            this.gChannels.Name = "gChannels";
            this.gChannels.RowTemplate.Height = 25;
            this.gChannels.Size = new System.Drawing.Size(322, 384);
            this.gChannels.TabIndex = 7;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 56;
            // 
            // nName
            // 
            this.nName.DataPropertyName = "Name";
            this.nName.HeaderText = "Name";
            this.nName.Name = "nName";
            this.nName.Width = 64;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 53;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.gChannels);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.textProcessing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Slack Channel Archiver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private Label label1;
        private TextBox textFound;
        private Label label2;
        private TextBox textProcessing;
        private Button btnArchive;
        private DataGridView gChannels;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn nName;
        private DataGridViewTextBoxColumn Age;
    }
}