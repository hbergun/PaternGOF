using System;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new Bmw(); //Upcasting
            CarDirector carDirector = new CarDirector(carBuilder);
            Console.WriteLine(carBuilder.GetCar.ToString());

            carBuilder = new Mercedes(); //Upcasting
            carDirector = new CarDirector(carBuilder);
            Console.WriteLine(carBuilder.GetCar.ToString());

            Console.Read();
        }
    }
}
