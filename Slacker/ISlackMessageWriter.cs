namespace Slacker
{
    public interface ISlackMessageWriter
    {
        void Write(string channelName, string from, string message);
    }
}