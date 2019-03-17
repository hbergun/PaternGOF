using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ShieldComposite : ITankShield
    {
        public string Defence()
        {
            return "Composite Shield Protected Tank";
        }
    }
}
