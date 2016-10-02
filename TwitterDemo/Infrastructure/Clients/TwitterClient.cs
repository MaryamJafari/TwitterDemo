using RestSharp;

namespace TwitterDemo.Infrastructure.Clients
{
    public class TwitterClient : ITwitterClient
    {
        private const string USER_TIMELINE_RESOURCE = "/twitter/user_timeline/{screenName}";
        private const string FRIENDS_RESOURCE = "twitter/friends/{screenName}";
        private const string SEARCH_RESOURCE = "/twitter/users/search/{q}";
        private const string TWEETS_RESOURCE = "/twitter/tweets/{q}";

        private readonly IRestClient restClient;

        public TwitterClient(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
        }

        public string Friends(string screenName)
        {
            var request = new RestRequest(FRIENDS_RESOURCE, Method.GET)
                .AddUrlSegment("screenName", screenName);
            var response = restClient.Execute(request);
            return response.Content;
        }

        public string Search(string query)
        {
            var request = new RestRequest(SEARCH_RESOURCE, Method.GET)
                .AddUrlSegment("q", query);
            var response = restClient.Execute(request);
            return response.Content;
        }

        public string Tweets(string query)
        {
            var request = new RestRequest(TWEETS_RESOURCE, Method.GET)
                .AddUrlSegment("q", query);
            var response = restClient.Execute(request);
            return response.Content;
        }

        public string UserTimeline(string screenName)
        {
            var request = new RestRequest(USER_TIMELINE_RESOURCE, Method.GET)
                .AddUrlSegment("screenName", screenName);
            var response = restClient.Execute(request);
            return response.Content;
        }
    }
}
