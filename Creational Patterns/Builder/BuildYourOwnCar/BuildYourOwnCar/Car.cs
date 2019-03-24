using System;
using System.Collections.Generic;
using System.Text;

namespace BuildYourOwnCar
{
    public abstract class Car
    {
        public Car()
        {
            _stockParts = new List<string>();
            _stockParts.AddRange(new string[] { "Wheel", "Engine", "Exhaust" });
            _optionalParts = new List<string>();
        }
        protected List<string> _stockParts;
        private List<string> _optionalParts;
        protected string model;

        public List<string> OptionalParts
        {
            get
            {
                return _optionalParts;
            }
            set
            {
                _optionalParts = value;
            }
        }
    }
}
