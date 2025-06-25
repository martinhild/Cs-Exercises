

namespace OOP_Animals;

internal class Dog: Animal, IAnimalAction
{
    // Constructor
    public Dog(int age): base(age) { }

    // Methods
    public override void Speak()
    {
        Console.WriteLine("The dog barks!");
    }

    public void Eat()
    {
        Console.WriteLine("The dog is eating his dog food");
    }
}

