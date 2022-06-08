public interface IWalking
{
    public string name {get;}
    void Run();
    void Walk();
}

public interface ISwimming
{
    int MaximumDepth { get; }
    void Swim();
}

public interface IFlying
{
    public string name {get;}

    void Fly();
}