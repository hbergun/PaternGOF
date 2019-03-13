using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class FactoryCreator
    {
        public static object GetFactory(string CarBrand)
        {
            CarBrand = char.ToUpper(CarBrand[0]) + CarBrand.ToLower().Substring(1);//The name of the class was converted:First Character was converted UpperCase //Car Brands
            Type type = Type.GetType("VehicleFactory." + CarBrand + "Factory");
            if (type != null)
                return Activator.CreateInstance(type,true); //first paramater:Type Name   After:Params Constructor 
            else
                return null;
        }
    }
}
