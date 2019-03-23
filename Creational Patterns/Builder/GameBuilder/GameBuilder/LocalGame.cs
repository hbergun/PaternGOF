namespace GameBuilder
{
    class LocalGame : Game
    {
        public LocalGame(int aiStrength, string season, string country)
            : base(season, country)
        {
            AiStrength = aiStrength;
        }

        public int AiStrength { get; }
    }
}