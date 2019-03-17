using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class Mercedes : Car
    {
        public Mercedes(int CarAge, decimal CarPrice)
        {
            base.CarAge = CarAge;
            base.CarPrice = CarPrice;
        }
        public override enBrands CarBrand { get => enBrands.Mercedes; set => base.CarBrand = value; }
        public override enColors CarColor { get => enColors.Black; set => base.CarColor = value; }
        public override string DoDrift()
        {
            return "Mercedes doing drift";
        }

    }
}
