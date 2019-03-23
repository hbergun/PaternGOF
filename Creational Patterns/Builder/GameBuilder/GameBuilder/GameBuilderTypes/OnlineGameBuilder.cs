using System;
using System.Collections.Generic;
using System.Text;

namespace GameBuilder
{
    public class OnlineGameBuilder : GameBuilder<OnlineGame, OnlineGameBuilder>
    {
        private string _serverUrl = "http://SmileGameServer.com/";

        protected override OnlineGameBuilder BuilderInstance => this;

        public OnlineGameBuilder ServerUrl(string serverUrl)
        {
            _serverUrl = serverUrl;
            return this;
        }

        public override OnlineGame Build() =>
            new OnlineGame(_serverUrl, _country, _season);
    }
}
