using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class LeoparkTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new LeopardTank();
        }

        public ITankGun GetTankGun()
        {
            return new Gun150MM();
        }

        public ITankShield GetTankShield()
        {
            return new ShieldComposite();
        }
    }
}
