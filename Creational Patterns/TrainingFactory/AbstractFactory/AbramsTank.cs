using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AbramsTank : Tank
    {
        public override ITankGun TankGun
        {
            get
            {
                return new Gun50MM();
            }
        }

        public override ITankShield TankShield
        {
            get
            {
                return new ShieldCarbon();
            }
        }

        public override string GetTankInfo()
        {
            return "Abrams Tank Uses Gun:" + TankGun + "Shield:" + TankShield;
        }
    }
}
