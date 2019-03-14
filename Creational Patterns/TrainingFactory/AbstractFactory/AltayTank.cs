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

        public override void GetTankInfo()
        {
            Console.WriteLine("Altay Tank Uses Gun:" + TankGun + "Shield:" + TankShield);
        }
    }
}
