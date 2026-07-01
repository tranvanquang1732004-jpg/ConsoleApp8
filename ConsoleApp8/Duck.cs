namespace ConsoleApp8;

public class Duck : Animal
{
    public Duck(string name) : base(name) { }
    public override void Sound() => Console.WriteLine("Quack!");
}