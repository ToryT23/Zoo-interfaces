using System;
public class Cat :IWalking
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
}