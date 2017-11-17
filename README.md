# Slacker
.NET Library for Slack message integration

# Getting started
It's a simple as this...
```csharp
ISlackConnectionProvider connectionProvider = new SlackConnectionProvider("Slack_WebHook_Url_With_Key_Here");
ISlackMessageWriter messageWriter = new SlackMessageWriter(connectionProvider);

messageWriter.Write("Channel Name", "Slacker", "Wow, we just sent a message to Slack using Slacker!");
```
