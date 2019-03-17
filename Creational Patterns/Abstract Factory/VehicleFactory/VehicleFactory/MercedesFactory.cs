using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class MercedesFactory : IVehicleFactory
    {
        public Car GetCar(int CarAge, decimal CarPrice)
        {
            return new Mercedes(CarAge, CarPrice);
        }

        public ICarEngine GetCarEngine()
        {
            return new Gasoline();
        }

        public ICarLight GetCarLight()
        {
            return new Xenon();
        }
    }
}
