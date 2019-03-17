using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AltayTank : Tank
    {
        public override ITankGun TankGun
        {
            get
            {
                return new Gun80MM();
            }
        }

        public override ITankShield TankShield
        {
            get
            {
                return new ShieldSteel();
            }
        }

        public override string GetTankInfo()
        {
            return "Altay Tank Uses Gun:" + TankGun + "Shield:" + TankShield;
        }
    }
}
