namespace Slacker
{
    public class SlackMessageWriter : ISlackMessageWriter
    {
        private readonly ISlackConnectionProvider connectionProvider;

        public SlackMessageWriter(ISlackConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public void Write(string channelName, string from, string message)
        {
            var slackConnection = connectionProvider.Provide();

            slackConnection.SendMessage(channelName, from, message);
        }
    }
}