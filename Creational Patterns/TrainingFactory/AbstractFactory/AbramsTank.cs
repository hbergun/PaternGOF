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

        public override void GetTankInfo()
        {
            Console.WriteLine("Abrams Tank Uses Gun:" + TankGun + "Shield:" + TankShield);
        }
    }
}
