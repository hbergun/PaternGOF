using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class LeopardTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new LeopardTank();
        }

        public ITankGun GetTankGun()
        {
            return new Gun50MM();
        }

        public ITankShield GetTankShield()
        {
            return new ShieldComposite();
        }
    }
}
