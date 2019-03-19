using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    public class Mercedes : CarBuilder
    {
        public Mercedes()
        {
            _car = new Car { Brand = "Mercedes" };
        }

        public override void EngineMontage()
        {
            _car.Engine = "2.0 TDI";
        }

        public override void WheelMontage()
        {
            _car.Engine = "Continental Premium Contact 5";
        }
    }
}
