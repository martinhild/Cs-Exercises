
namespace OOP_Vehicles;

internal class OOPVehiclesDemo
{
    public static void Run()
    {
        Bicycle bike = new Bicycle(15);
        Car car = new Car(100);

        bike.Drive();

        car.Drive();

        Console.WriteLine($"The car makes a sound:");
        car.Horn();
    }

}

