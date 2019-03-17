using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public static class FactoryCreator
    {
        public static ITankFactory GetTankFactory(string TankBrand)
        {
            TankBrand = char.ToUpper(TankBrand[0]) + TankBrand.ToLower().Substring(1);//The name of the class was converted:First Character was converted UpperCase //Car Brands
            Type type = Type.GetType("AbstractFactory." + TankBrand + "TankFactory");
            if (type != null)
                return (ITankFactory)Activator.CreateInstance(type, true); //first paramater:Type Name   After:Params Constructor 
            else
                return null;
        }
    }
}
