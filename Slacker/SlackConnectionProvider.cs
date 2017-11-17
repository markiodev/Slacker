namespace Slacker
{
    public class SlackConnectionProvider : ISlackConnectionProvider
    {
        private readonly string _slackWebHookUrl;

        public SlackConnectionProvider(string slackWebHookUrl)
        {
            _slackWebHookUrl = slackWebHookUrl;
        }

        public ISlackConnection Provide()
        {
            return new SlackConnection(new SlackClient(_slackWebHookUrl));
        }
    }
}