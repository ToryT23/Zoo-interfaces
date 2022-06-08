using System;
public class Seagull : IFlying
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

    public int MaximumDepth { get; } = 10;

    public void Swim()
    {
        Console.WriteLine("Swim, Swim");
    }
}