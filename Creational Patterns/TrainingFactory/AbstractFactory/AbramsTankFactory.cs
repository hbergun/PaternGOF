using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AbramsTankFactory : ITankFactory
    {
        public Tank GetTank()
        {
            return new AbramsTank();
        }
    }
}
