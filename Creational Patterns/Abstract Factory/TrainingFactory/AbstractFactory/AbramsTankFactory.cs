using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AbramsTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new AbramsTank();
        }

        public ITankGun GetTankGun()
        {
            return new Gun150MM();
        }

        public ITankShield GetTankShield()
        {
            return new ShieldCarbon();
        }
    }
}
