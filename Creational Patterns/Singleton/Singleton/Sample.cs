using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Sample
    {
        private static Sample _sample;
        protected Sample() { }
        public static Sample CreateObject() //Classic
        {
            if (_sample == null)
            {
                _sample = new Sample();
            }
            return _sample;
        }

        public static Sample CreateObjectV2() //Diffrent Coding Standart
        {
            return _sample ?? (_sample = new Sample());
        }

        //C# Special :)
        public static Sample GetSample
        {
            get
            {
                return _sample ?? (_sample = new Sample());
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
