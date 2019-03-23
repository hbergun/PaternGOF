using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public class EmailAccount
    {
        private string _ServiceProvider { get; set; }
        private string _MailExtension { get; set; }
        private string _MailOwner { get; set; }

        public EmailAccount(string ServiceProvider,string MailExtension,string MailOwner)
        {
            _ServiceProvider = ServiceProvider;
            _MailExtension = MailExtension;
            _MailOwner = MailOwner;

        }

        public override string ToString()
        {
            return $"Service Provider:{_ServiceProvider},Mail Extension:{_MailExtension},Mail Owner:{_MailOwner}";
            //return base.ToString();
        }
    }
}
