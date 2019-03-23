using System;
using System.Collections.Generic;
using System.Text;

namespace GameBuilder
{
    public abstract class GameBuilder<TGame,TBuilder> where TGame : Game
                                             where TBuilder : GameBuilder<TGame,TBuilder>
    {
        protected string _season = "Winter"; //Default
        protected string _country  = "Turkey"; //Default
        protected abstract TBuilder BuilderInstance { get; }

        public TBuilder Season(string season)
        {
            _season = season;
            return BuilderInstance; //Fluent Design Pattern
        }

        public TBuilder Country(string country)
        {
            _country = country;
            return BuilderInstance; //Fluent Design Pattern
        }

        public abstract TGame Build();
    }
}
