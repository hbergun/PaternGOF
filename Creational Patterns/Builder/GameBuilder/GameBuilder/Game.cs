namespace GameBuilder
{
    public abstract class Game
    {
        public Game(string _season, string _country)
        {
            Season = _season;
            Country = _country;
        }

        public string Season { get; }

        public string Country{ get; }

    }
}