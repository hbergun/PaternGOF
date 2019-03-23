namespace GameBuilder
{
    public class LocalGame : Game
    {
        public LocalGame(int difficulty, string season, string country) : base(season, country)
        {
            Difficulty = difficulty;
        }

        public int Difficulty { get; }
    }
}