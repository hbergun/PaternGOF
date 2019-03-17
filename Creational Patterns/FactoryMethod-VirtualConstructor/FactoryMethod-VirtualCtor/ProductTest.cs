using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_VirtualCtor
{
    public class ProductTest
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger _logger;
        public ProductTest(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.GetLogger();
        }

        public void Save()
        {
            _logger.Log();
        }
    }
}
