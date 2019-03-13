using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ShieldAlloy : ITankShield
    {
        public string Defence()
        {
            return "Alloy Shield Protected Tank";
        }
    }
}
