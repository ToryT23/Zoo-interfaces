using System;

public class PaintedDog : IWalking
{
    public string name {get; set;}
    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }
}