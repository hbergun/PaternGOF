using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public abstract class EmailAccount
    {
        public string ServiceProvider { get; set; }
        public string MailExtension { get; set; }

        public override string ToString()
        {
            return $"Service Provider:{ServiceProvider},Mail Extension:{MailExtension}";
            //return base.ToString();
        }
    }
}
