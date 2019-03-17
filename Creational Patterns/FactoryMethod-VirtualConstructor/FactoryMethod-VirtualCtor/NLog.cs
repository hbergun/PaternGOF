using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public class NLog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("NLog Logged");
        }
    }
}
