using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public interface IVehicleFactory
    {
        ICarEngine GetCarEngine(); //Her Araba Fabrikam Motor Ve Far Üretebilir.
        ICarLight GetCarLight(); //Each Car Factory Produces Motor And Light.
        Car GetCar(int CarAge,decimal CarPrice);
    }
}
