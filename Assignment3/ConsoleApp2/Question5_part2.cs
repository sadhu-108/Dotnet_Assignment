using System;

partial class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped.");
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Year: " + Year);
    }
}