namespace Slacker
{
    public interface ISlackConnectionProvider
    {
        ISlackConnection Provide();
    }
}