using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    public class CarDirector
    {
        public CarDirector(CarBuilder carBuilder)
        {
            carBuilder.EngineMontage();
            carBuilder.WheelMontage();  
        }
    }
}
