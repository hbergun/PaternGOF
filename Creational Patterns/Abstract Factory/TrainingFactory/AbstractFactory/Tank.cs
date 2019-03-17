using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Tank
    {
        public abstract string TankGun { get; } //Re Created With Interface !!
        public abstract string TankShield { get; }
        public abstract string GetTankInfo();
    }
}

