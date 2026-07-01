namespace ConsoleApp8;


public interface IFly
{
    void Fly();
}

class Program
{
    static void Main()
    {
        IFly[] flyingObjects = { new Bird(), new Airplane(), new Superman() };

        foreach (var obj in flyingObjects)
        {
            obj.Fly();
        }
    }
}