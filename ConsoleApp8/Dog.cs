namespace ConsoleApp8;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void Sound() => Console.WriteLine("Woof!");
}