using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Sample
    {
        //volatile Keyword prevents simultaneous change for different CPUs 
        private static volatile Sample _sample; 
        private static readonly object lock_obj = new object();
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

        //Thread Safe Singleton
        public static Sample GetSampleThreadSafe
        {
            get
            {
                lock (lock_obj)
                {
                    return _sample ?? (_sample = new Sample());

                }
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
