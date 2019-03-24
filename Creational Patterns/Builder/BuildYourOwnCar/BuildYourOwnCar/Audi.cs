using System;
using System.Collections.Generic;
using System.Text;

namespace BuildYourOwnCar
{
    public class Audi : Car
    {
        public string Model
        {
            get
            {
                return base.model;
            }
            set
            {
                base.model = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"AUDI {model}\n\r");
            for (int i = 0; i < _stockParts.Count; i++)
            {
                sb.AppendLine(_stockParts[i] + "\n\r");
            }
            for (int i = 0; i < OptionalParts.Count; i++)
            {
                sb.AppendLine(OptionalParts[i] + "\n\r");
            }
            return sb.ToString();
        }
    }
}
