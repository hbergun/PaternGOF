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
            //BmwFactory Belirli Bir Formata Sokulabilir. İlk Harf Büyük "Bmw" "Mercedes" Şeklinde.
            Car MyCar  = ((IVehicleFactory)FactoryCreator.GetFactory("bmw")).GetCar(1,175000);
            Console.WriteLine(MyCar.DoDrift());
            Console.WriteLine(MyCar.CarAge);
            Console.WriteLine(MyCar.CarBrand);
            Console.WriteLine(MyCar.CarColor);
            Console.WriteLine(MyCar.CarPrice);
            MyCar = ((IVehicleFactory)FactoryCreator.GetFactory("mercedes")).GetCar(3, 475000);
            Console.WriteLine("********************************************************************");
            Console.WriteLine(MyCar.DoDrift());
            Console.WriteLine(MyCar.CarAge);
            Console.WriteLine(MyCar.CarBrand);
            Console.WriteLine(MyCar.CarColor);
            Console.WriteLine(MyCar.CarPrice);

            Console.Read();
        }
    }
}
