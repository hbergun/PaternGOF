using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    public abstract class CarBuilder
    {
        protected Car _car;
        public Car GetCar
        {
            get
            {
                return _car;
            }
        }
        public abstract void EngineMontage();
        public abstract void WheelMontage();
    }
}
