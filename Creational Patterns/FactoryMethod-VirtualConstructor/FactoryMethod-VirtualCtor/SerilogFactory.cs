using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public class SerilogFactory : ILoggerFactory
    {
        public ILogger GetLogger()
        {
            return new Serilog();
        }
    }
}
