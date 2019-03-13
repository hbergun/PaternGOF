using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Tank
    {
        public abstract ITankGun GetTankGun();
        public abstract ITankShield GetTankShield();
    }
}
