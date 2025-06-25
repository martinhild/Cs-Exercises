
namespace OOP_Vehicles;

internal class Bicycle: Vehicle
{
    public Bicycle(int kmh): base(kmh) { }
    public override void Drive()
    {
        Console.WriteLine($"The bicycle is driving at {Speed} km/h.");
    }
}
