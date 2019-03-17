using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AbramsTank : Tank
    {
        public override string TankGun
        {
            get
            {
                return "Gun 50MM";
            }
        }

        public override string TankShield
        {
            get
            {
                return "Shield Carbon";
            }
        }

        public override string GetTankInfo()
        {
            return "Abrams Tank Uses Gun:" + TankGun + "Shield:" + TankShield;
        }
    }
}
