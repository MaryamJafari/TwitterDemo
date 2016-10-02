using System;
using System.Windows.Forms;
using TwitterDemo.Infrastructure.Clients;

namespace TwitterDemo
{
    public partial class MainForm : Form
    {
        private const string BASE_URL = "http://localhost:8080";

        private readonly ITwitterClient twitterClient;

        public MainForm()
        {
            InitializeComponent();

            twitterClient = new TwitterClient(BASE_URL);
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            string parameter = queryTextBox.Text;
            string endpoint = endpointsComboBox.SelectedItem?.ToString().ToLower();
            string response;
            switch (endpoint)
            {
                case "tweets":
                    response = twitterClient.Tweets(parameter);
                    break;
                case "friends":
                    response = twitterClient.Friends(parameter);
                    break;
                case "timeline":
                    response = twitterClient.UserTimeline(parameter);
                    break;
                case "search":
                    response = twitterClient.Search(parameter);
                    break;
                default:
                    response = "No Result";
                    break;
            }
            responseTextBox.Text = response;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            endpointsComboBox.SelectedIndex = 0;
        }
    }
}
