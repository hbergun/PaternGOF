using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public interface IVehicleFactory
    {
        ICarEngine GetCarEngine(); //Her ArabaFabrikam Motor Ve Far Üretebilir.
        ICarLight GetCarLight();
    }
}
