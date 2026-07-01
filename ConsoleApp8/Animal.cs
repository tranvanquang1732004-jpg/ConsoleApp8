namespace ConsoleApp8;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
    
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public abstract void Sound();
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog("Buddy");
        Animal myCat = new Cat("Kitty");
        Animal myDuck = new Duck("Donald");

        myDog.Eat(); myDog.Sound();
        myCat.Eat(); myCat.Sound();
        myDuck.Eat(); myDuck.Sound();
    }
}

