namespace ConsoleApp8;

public class Bike : Vehicle
{
    public Bike(string brand, double speed) : base(brand, speed) { }
    public override void Move() => Console.WriteLine($"{Brand} moves on path at {Speed} km/h.");
}