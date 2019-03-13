using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ITankFactory
    {
        ITankGun GetTankGun();
        ITankShield GetTankShield();
        Tank GetTank();
    }
}
