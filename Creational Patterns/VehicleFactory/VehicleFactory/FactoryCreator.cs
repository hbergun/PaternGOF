using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    public class FactoryCreator
    {
        public object CreateCar(string CarType)
        {
            CarType = char.ToUpper(CarType[0]) + CarType.Substring(1); //Class Name With First Character UpperCase //Car Brands
            Type type = Type.GetType("VehicleFactory."+CarType+"Factory");
            if (type != null)
                return Activator.CreateInstance(type,CarType);
            else
                return null;
        }
    }
}
