using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public abstract class Car
    {
        public enum enBrands
        {
            Audi,
            Mercedes,
            Bmw,
            Porche,
            Ferrari
        }
        public enum enColors
        {
            Red,
            Black,
            White,
            Blue
        }


        private enBrands carBrand;
        public virtual enBrands CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }

        private enColors carColor;
        public virtual enColors CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }
        public virtual int CarAge { get; set; }
        public virtual decimal CarPrice { get; set; }

        public abstract string DoDrift();

    }
}
