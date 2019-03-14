using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Tank
    {
        public abstract ITankGun TankGun { get; } //Re Created With Interface !!
        public abstract ITankShield TankShield { get; }
        public abstract void GetTankInfo();
    }
}

