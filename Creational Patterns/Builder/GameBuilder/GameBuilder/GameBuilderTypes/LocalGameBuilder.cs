using System;
using System.Collections.Generic;
using System.Text;

namespace GameBuilder
{
    public class LocalGameBuilder : GameBuilder<LocalGame, LocalGameBuilder>
    {
        private int _difficulty = 3; //Default
        protected override LocalGameBuilder BuilderInstance => this;

        public LocalGameBuilder Difficulty(int difficulty)
        {
            _difficulty = difficulty;
            return this;
        }

        public override LocalGame Build()
        {
            return new LocalGame(_difficulty, _season, _country);
        }
    }
}
