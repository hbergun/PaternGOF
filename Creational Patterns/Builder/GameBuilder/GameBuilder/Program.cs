using System;

namespace GameBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineGameBuilder onlineGame = new OnlineGameBuilder();
            onlineGame
                .Country("Mexica")
                .Season("Summer")
                .ServerUrl("www.berksgame.com")
                .Build();
            Console.Read();
        }
    }
}
