using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public class Serilog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Serilog Logged");
        }
    }
}
