using System;

namespace GameBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineGameBuilder onlineGame = new OnlineGameBuilder();
            onlineGame
                .Country("South Korea")
                .Season("Winter")
                .ServerUrl("www.mmopgame.com") //Difference Between  Online Game and Local Game
                .Build();
            LocalGameBuilder localGame = new LocalGameBuilder();
            localGame
                .Country("Turkey")
                .Season("Summer")
                .Difficulty(7)
                .Build();
            Console.Read();
        }
    }
}
