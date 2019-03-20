using System;

namespace MailBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailBuilder emailBuilder = new EmailBuilder();
            EmailAccount mail =
                 emailBuilder
                .SetMailExtension("gmail.com")
                .SetServiceProvider("Google Corp")
                .SetMailOwner("hbergun")
                .Build();
            Console.WriteLine(mail.ToString());
            Console.Read();
        }
    }
}
