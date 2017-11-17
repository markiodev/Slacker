# Slacker
.NET Library for Slack message integration

## Installing
Install-Package Slacker

OR

dotnet add package Slacker

# Getting started
It's a simple as...

```csharp
ISlackConnectionProvider connectionProvider = new SlackConnectionProvider("Slack_WebHook_Url_With_Key_Here");
ISlackMessageWriter messageWriter = new SlackMessageWriter(connectionProvider);

messageWriter.Write("Channel Name", "Slacker", "Wow, we just sent a message to Slack using Slacker!");
```
