using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class BmwFactory : IVehicleFactory
    {
        public BmwFactory(string comemark)
        {
            TradeMark = comemark;
        }
        public string TradeMark { get; set; }
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
