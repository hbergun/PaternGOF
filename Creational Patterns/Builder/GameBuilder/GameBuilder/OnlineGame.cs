namespace GameBuilder
{
    public class OnlineGame : Game
    {
        public OnlineGame(string serverUrl, string season , string country): base(season, country)
        {
            ServerUrl = serverUrl;
        }

        public string ServerUrl { get; set; }
    }

}