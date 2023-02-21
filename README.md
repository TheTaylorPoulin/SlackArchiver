# SlackArchiver
A simple tool for finding stale channels and archiving them

## Limitations
- you need to use your own user token with the following scopes:
  - channels:history
  - channels:read
  - channels:write
  - groups::history
  - groups:read
  - groups:write
- the tool won't see private channels you are not a part of
- rate limiting will slow things down drastically if you use the tool repeatedly
