using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AltayTank : Tank
    {
        public override string TankGun
        {
            get
            {
                return "Gun 80MM";
            }
        }

        public override string TankShield
        {
            get
            {
                return "Shield Steel";
            }
        }

        public override string GetTankInfo()
        {
            return "Altay Tank Uses Gun:" + TankGun + "Shield:" + TankShield;
        }
    }
}
