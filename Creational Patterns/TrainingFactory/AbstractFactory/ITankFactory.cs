using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ITankFactory //Tank Factory Produces a new Tank<T>
    {
        Tank GetTank();
        ITankGun GetTankGun();
        ITankShield GetTankShield();
    }
}
