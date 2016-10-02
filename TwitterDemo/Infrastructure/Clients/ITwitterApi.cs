namespace TwitterDemo.Infrastructure.Clients
{
    public interface ITwitterClient
    {
        string UserTimeline(string screenName);
        string Friends(string screenName);
        string Search(string query);
        string Tweets(string query);
        string Languages();
        string Privacy();
        string Configuration();
        string Suggestions();
    }
}