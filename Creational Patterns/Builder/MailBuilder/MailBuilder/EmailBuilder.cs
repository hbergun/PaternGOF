using System;
using System.Collections.Generic;
using System.Text;

namespace MailBuilder
{
    public abstract class EmailBuilder
    {
        protected EmailAccount _emailAccount;
        public EmailAccount GetEmailAccount
        {
            get
            {
                return _emailAccount;
            }
        }
        public abstract string SetServiceProvider();
        public abstract string SetMailExtension();
    }
}
