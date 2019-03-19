using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    public class Bmw : CarBuilder
    {
        public Bmw()
        {
            _car = new Car { Brand = "Bmw" };
        }
        public override void EngineMontage()
        {
            _car.Engine = "1.6 Gasoline";
        }

        public override void WheelMontage()
        {
            _car.Wheel = "Lassa SnowWays 3";
        }
    }
}
