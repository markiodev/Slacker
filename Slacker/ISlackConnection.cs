namespace Slacker
{
    public interface ISlackConnection
    {
        void SendMessage(string channelName, string from, string message);
    }
}