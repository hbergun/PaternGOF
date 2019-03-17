using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Sample Instance;
            Instance = Sample.CreateObject();
            Instance.ShowMessage("Classic");
            Instance = Sample.CreateObjectV2();
            Instance.ShowMessage("Version 2");
            Instance = Sample.GetSample; // Best Practice
            Instance.ShowMessage("Best Practice");
            Console.Read();
        }
    }
}
