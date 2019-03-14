using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AltayTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new AltayTank();
        }
    }
}
