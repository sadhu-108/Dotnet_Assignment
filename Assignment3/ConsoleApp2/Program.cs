using System;

class Program
{
    static void Main(string[] args)
    {
        EmailNotification email = new EmailNotification();
        email.SendNotification();

        SpecialEmailNotification specialEmail =
            new SpecialEmailNotification();

        specialEmail.SendNotification();
        specialEmail.SendSpecialNotification();

        Console.ReadLine();
    }
}