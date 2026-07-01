namespace ConsoleApp8;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void Sound() => Console.WriteLine("Meow!");
}