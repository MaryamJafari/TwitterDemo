namespace TwitterDemo.Infrastructure.Clients
{
    public interface ITwitterClient
    {
        string UserTimeline(string screenName);
        string Friends(string screenName);
        string Search(string query);
        string Tweets(string query);
    }
}