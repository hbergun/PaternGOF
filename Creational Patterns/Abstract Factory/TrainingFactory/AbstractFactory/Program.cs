using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank AbramsTankInstance = FactoryCreator.GetTankFactory("abrams").GetTank();
            Console.WriteLine(AbramsTankInstance.GetTankInfo());
            ITankGun AbramsTankGunInstance = FactoryCreator.GetTankFactory("abrams").GetTankGun();
            Console.WriteLine(AbramsTankGunInstance.Fire());
            ITankShield AbramsTankShieldInstance = FactoryCreator.GetTankFactory("abrams").GetTankShield();
            Console.WriteLine(AbramsTankShieldInstance.Defence());
            //Same
            Tank LeopardTankInstance = FactoryCreator.GetTankFactory("leopard").GetTank();
            Console.WriteLine(LeopardTankInstance.GetTankInfo());
            Tank AltayTankInstance = FactoryCreator.GetTankFactory("altay").GetTank();
            Console.WriteLine(AltayTankInstance.GetTankInfo());
            Console.Read();
        }
    }
}
