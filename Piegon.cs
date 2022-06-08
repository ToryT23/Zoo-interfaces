using System;

public class Pigeon : IFlying
{
    public string name {get; set;}
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }

    public void Fly()
    {
        Console.WriteLine("I'm in the air!");
    }
}