using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public class Gmail : EmailBuilder
    {
        public Gmail()
        {
            _emailAccount = new EmailAccount();
        }
        public override void SetMailExtension()
        {
            _emailAccount.MailExtension = "gmail.com";
        }

        public override void SetServiceProvider()
        {
            _emailAccount.ServiceProvider = "Google Corp";
        }
    }
}
