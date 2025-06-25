
namespace OOP_Animals;

internal class OOPAnimalsDemo
{
    public static void Run()
    {
        Dog dog = new Dog(3);
        Cat cat = new Cat(7);

        dog.Speak();
        dog.Eat();
        cat.Speak();
        cat.Eat();

    }    
}
