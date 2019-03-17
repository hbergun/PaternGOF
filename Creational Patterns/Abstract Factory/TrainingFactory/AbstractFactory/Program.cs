using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank AbramsTankInstance = FactoryCreator.GetTankFactory("abrams").GetTank();
            Console.WriteLine(AbramsTankInstance.GetTankInfo());
            Tank LeopardTankInstance = FactoryCreator.GetTankFactory("leopard").GetTank();
            Console.WriteLine(LeopardTankInstance.GetTankInfo());
            Tank AltayTankInstance = FactoryCreator.GetTankFactory("altay").GetTank();
            Console.WriteLine(AltayTankInstance.GetTankInfo());
            Console.Read();
        }
    }
}
