using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder
{
    public class Car
    {
        public string Brand { get; set; }
        public string Engine { get; set; }
        public string Wheel { get; set; }

        public override string ToString()
        {
            return $"Brand:{Brand},Engine:{Engine},Wheel{Wheel}";
        }
    }
}
