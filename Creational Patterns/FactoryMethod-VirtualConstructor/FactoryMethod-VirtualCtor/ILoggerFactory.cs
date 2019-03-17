using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public interface ILoggerFactory
    {
        ILogger GetLogger();
    }
}
