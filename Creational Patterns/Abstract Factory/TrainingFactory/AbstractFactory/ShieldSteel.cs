using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ShieldSteel : ITankShield
    {
        public string Defence()
        {
            return "Steel Shield Protected Tank";
        }
    }
}
