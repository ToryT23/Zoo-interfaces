using System;
public class Platypus
{
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }

    public int MaximumDepth { get; } = 10;

    public void Swim()
    {
        Console.WriteLine("Swim, Swim");
    }
}