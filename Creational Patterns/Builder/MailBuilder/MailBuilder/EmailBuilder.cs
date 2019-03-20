using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public class EmailBuilder
    {
        private string _ServiceProvider;
        private string _MailExtension;
        private string _MailOwner;

        public EmailBuilder SetServiceProvider(string ServiceProvider)
        {
            _ServiceProvider = ServiceProvider;
            return this;
        }

        public EmailBuilder SetMailExtension(string Extension)
        {
            _MailExtension = Extension;
            return this;
        }

        public EmailBuilder SetMailOwner(string Name)
        {
            _MailOwner = Name;
            return this;
        }

        public EmailAccount Build()
        {
            return new EmailAccount(_ServiceProvider,_MailExtension,_MailOwner);
        }
    }
}
