namespace ConsoleApp8;

public class Duck1 : IFly1, ISwim
{
    public void Fly() => Console.WriteLine("Duck is flying.");
    public void Swim() => Console.WriteLine("Duck is swimming.");
}