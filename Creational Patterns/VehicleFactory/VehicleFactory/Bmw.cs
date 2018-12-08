using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class Bmw:Car
    {
        public Bmw(int CarAge,decimal CarPrice)
        {
            base.CarAge = CarAge;
            base.CarPrice = CarPrice;
        }
        public override enBrands CarBrand { get => enBrands.Bmw; set => base.CarBrand = value; }
        public override enColors CarColor { get => enColors.Blue; set => base.CarColor = value; }
        public override string DoDrift()
        {
            return "Bmw doing drift";
        }
    }
}
