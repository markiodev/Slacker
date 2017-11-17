namespace Slacker
{
    public class SlackConnection : ISlackConnection
    {
        private readonly SlackClient client;

        public SlackConnection(SlackClient client)
        {
            this.client = client;
        }

        public void SendMessage(string channelName, string @from, string message)
        {
            this.client.PostMessage(message, from, channelName);
        }
    }
}