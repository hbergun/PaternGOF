using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public class Outlook : EmailBuilder
    {
        public Outlook()
        {
            _emailAccount = new EmailAccount();
        }
        public override void SetMailExtension()
        {
            _emailAccount.MailExtension = "outlook.com";
        }

        public override void SetServiceProvider()
        {
            _emailAccount.ServiceProvider = "Microsoft Corp";
        }
    }
}
