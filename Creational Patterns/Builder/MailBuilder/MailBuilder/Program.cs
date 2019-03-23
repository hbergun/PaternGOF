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
            EmailAccount mail2 =
                emailBuilder
                .SetMailOwner("mreorhan")
                .Build();

            Console.WriteLine(mail2.ToString());
            Console.Read();
        }
    }
}
