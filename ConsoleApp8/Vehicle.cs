namespace ConsoleApp8;


public abstract class Vehicle
{
    public string Brand { get; set; }
    public double Speed { get; set; }

    public Vehicle(string brand, double speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Start() => Console.WriteLine($"{Brand} is starting.");
    public void Stop() => Console.WriteLine($"{Brand} is stopping.");


    public abstract void Move();
}


class Program
{
    static void Main()
    {
        Vehicle myCar = new Car("Toyota", 120);
        Vehicle myBike = new Bike("Giant", 20);
        Vehicle myBoat = new Boat("Yamaha", 50);

        myCar.Start(); myCar.Move(); myCar.Stop();
        Console.WriteLine("-------------------");
        myBike.Start(); myBike.Move(); myBike.Stop();
        Console.WriteLine("-------------------");
        myBoat.Start(); myBoat.Move(); myBoat.Stop();
    }
}