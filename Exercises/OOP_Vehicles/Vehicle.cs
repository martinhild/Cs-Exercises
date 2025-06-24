
namespace FQ_Programmieraufgaben.Exercises.OOP_Vehicles
{
    internal class Vehicle
    {
        // Properties
        public int Speed { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"Driving with {Speed} km/h.");
        }
    }
}
