using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    internal class Diesel : ICarEngine
    {
        public string GetEngineInfo()
        {
            return "Bu Marka Diesel Motor Kullanıyor.";
        }
    }
}
