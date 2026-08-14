using System;

abstract class Notification
{
    public abstract void SendNotification();
}

class EmailNotification : Notification
{
    public override void SendNotification()
    {
        Console.WriteLine("Email notification sent.");
    }
}

sealed class SpecialEmailNotification : EmailNotification
{
    public void SendSpecialNotification()
    {
        Console.WriteLine("Special email notification sent.");
    }
}