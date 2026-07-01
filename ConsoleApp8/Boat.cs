namespace ConsoleApp8;

public class Boat : Vehicle
{
    public Boat(string brand, double speed) : base(brand, speed) { }
    public override void Move() => Console.WriteLine($"{Brand} moves on water at {Speed} km/h.");
}