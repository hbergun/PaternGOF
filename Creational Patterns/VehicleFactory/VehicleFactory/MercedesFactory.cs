using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class MercedesFactory : IVehicleFactory
    {
        public MercedesFactory(string comeMark)
        {
            TradeMark = comeMark;
        }
        public string TradeMark { get; set; }
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
