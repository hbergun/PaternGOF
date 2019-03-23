using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class LeopardTank : Tank
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
                return "Shield Composite";
            }
        }

        public override string GetTankInfo()
        {
            return "Leopard Uses Gun:" + TankGun + "Shield:" + TankShield;
        }
    }
}
