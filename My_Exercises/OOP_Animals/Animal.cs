

namespace OOP_Animals;

internal class Animal
{
    // Properties
    public int Age { get; set; }

    // Constructor
    public Animal(int age)
    {
        Age = age;
    }

    // Virtual Methods
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
