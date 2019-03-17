using System;

namespace FactoryMethod_VirtualCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest productTestNLog = new ProductTest(new NLogFactory());
            productTestNLog.Save();
            ProductTest productTestSerilog = new ProductTest(new SerilogFactory());
            productTestSerilog.Save();
            Console.Read();
                
        }
    }
}
