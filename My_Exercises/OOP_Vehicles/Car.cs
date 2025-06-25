
namespace OOP_Vehicles;

internal class Car: Vehicle, IHorn
{
    // Constructor
    public Car(int kmh) : base(kmh) { }
    
    // Methods
    public override void Drive()
    {
        Console.WriteLine($"The car is driving at {Speed} km/h.");
    }

    public void Horn()
    {
        Console.WriteLine("Honk, honk!");
    }
}
