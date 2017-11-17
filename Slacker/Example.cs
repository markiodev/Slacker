namespace Slacker
{
    internal class Example
    {
        public Example()
        {
            ISlackConnectionProvider connectionProvider = new SlackConnectionProvider("Slack_WebHook_Url_With_Key_Here");
            ISlackMessageWriter messageWriter = new SlackMessageWriter(connectionProvider);

            messageWriter.Write("Channel Name", "Slacker", "Wow, we just sent a message to Slack using Slacker!");
        }
    }
}