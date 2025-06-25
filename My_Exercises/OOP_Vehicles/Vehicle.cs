
namespace OOP_Vehicles;

internal class Vehicle
{
    // Properties
    public int Speed { get; set; }

    // Constructor
    public Vehicle(int kmh)
    {
        Speed = kmh;
    }

    // vitual Methods
    public virtual void Drive()
    {
        Console.WriteLine($"Driving with {Speed} km/h.");
    }
}
