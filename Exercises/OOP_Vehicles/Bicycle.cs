
namespace FQ_Programmieraufgaben.Exercises.OOP_Vehicles
{
    internal class Bicycle: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The bicycle is driving at {Speed} km/h.");
        }
    }
}
