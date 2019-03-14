using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class LeopardTank : Tank
    {
        public override ITankGun TankGun
        {
            get
            {
                return new Gun150MM();
            }
        }
        public override ITankShield TankShield
        {
            get
            {
                return new ShieldComposite();
            }
        }

        public override void GetTankInfo()
        {
            Console.WriteLine("Leopard Uses Gun:"+TankGun+"Shield:"+TankShield);
        }
    }
}
