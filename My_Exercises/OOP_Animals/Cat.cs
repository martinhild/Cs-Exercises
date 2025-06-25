

namespace OOP_Animals;

internal class Cat: Animal, IAnimalAction
{
    // Constructor
    public Cat(int age) : base(age) { }

    // Methods
    public override void Speak()
    {
        Console.WriteLine("The cat makes \"Miau!\"");
    }

    public void Eat()
    {
        Console.WriteLine("The cat eats a mouse");
    }
}
