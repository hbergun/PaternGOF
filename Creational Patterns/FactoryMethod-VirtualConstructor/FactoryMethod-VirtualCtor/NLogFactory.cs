using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public class NLogFactory : ILoggerFactory
    {
        public ILogger GetLogger()
        {
            return new NLog();
        }
    }
}
