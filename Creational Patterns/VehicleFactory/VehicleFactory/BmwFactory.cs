using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class BmwFactory : IVehicleFactory
    {
        public Car GetCar(int CarAge,decimal CarPrice)
        {
            return new Bmw(CarAge,CarPrice);
        }

        public ICarEngine GetCarEngine()
        {
            return new Diesel();
        }

        public ICarLight GetCarLight()
        {
            return new Led();
        }
    }
}
