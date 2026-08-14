using System;

static class ApplicationConfiguration
{
    public static string DatabaseConnectionString =
        "Server=localhost;Database=UniversityDB;Trusted_Connection=True;";

    public static string ApplicationName = "University Management System";

    public static string ApplicationVersion = "1.0";

    public static int MaxLoginAttempts = 3;

    public static void DisplayConfiguration()
    {
        Console.WriteLine("Application Name: " + ApplicationName);
        Console.WriteLine("Application Version: " + ApplicationVersion);
        Console.WriteLine("Database Connection: " + DatabaseConnectionString);
        Console.WriteLine("Max Login Attempts: " + MaxLoginAttempts);
    }
}