namespace ConsoleApp8;

public class Car : Vehicle
{
    public Car(string brand, double speed) : base(brand, speed) { }
    public override void Move() => Console.WriteLine($"{Brand} moves on road at {Speed} km/h.");
}