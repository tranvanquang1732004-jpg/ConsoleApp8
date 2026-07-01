namespace ConsoleApp8;


public interface IFly1
{
    void Fly();
}

public interface ISwim
{
    void Swim();
}

class Program
{
    static void Main()
    {
        Duck1 duck = new Duck1();
        Fish1 fish = new Fish1();
        Eagle eagle = new Eagle();

        duck.Fly();
        duck.Swim();
        
        fish.Swim();
        
        eagle.Fly();
    }
}