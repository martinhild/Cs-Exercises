
namespace FQ_Programmieraufgaben.Exercises.OOP_Vehicles
{
    internal class Car : Vehicle
    {
        public override void Drive()
            {
            Console.WriteLine($"The car is driving at {Speed} km/h.");
            }
    }
}
