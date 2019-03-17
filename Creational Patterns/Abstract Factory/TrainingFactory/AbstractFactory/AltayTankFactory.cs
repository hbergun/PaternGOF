using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AltayTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new AltayTank();
        }

        public ITankGun GetTankGun()
        {
            return new Gun80MM();
        }

        public ITankShield GetTankShield()
        {
            return new ShieldSteel();
        }
    }
}
