using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank NewTank = FactoryCreator.GetTankFactory("abrams").GetTank();
            NewTank.GetTankInfo();
        }
    }
}
