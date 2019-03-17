using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ShieldCarbon : ITankShield
    {
        public string Defence()
        {
            return "Carbon Shield Protected Tank";
        }
    }
}
