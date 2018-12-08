using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreator factoryCreator = new FactoryCreator();
            string Info=((BmwFactory)factoryCreator.CreateCar("bmw")).GetCarEngine().GetEngineInfo(); //BmwFactory Belirli Bir Formata Sokulabilir. İlk Harf Büyük "Bmw" "Mercedes" Şeklinde.
            Console.WriteLine(Info);
            Console.Read();
                
        }
    }
}
