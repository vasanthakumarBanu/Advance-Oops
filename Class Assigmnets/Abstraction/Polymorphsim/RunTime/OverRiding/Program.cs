using System;
namespace Overridding;
public class Animal
{
    public virtual void Eat()
    {
        System.Console.WriteLine("Animals Eat food");
    }
}
public class Dog : Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Dogs Eat food");
        base.Eat();
    }

}
public class Pomerian : Dog
{
    public override void Eat()
    {
        System.Console.WriteLine("Pomerian Eat food");
         base.Eat();
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Pomerian pomerian = new Pomerian();

        animal.Eat();
        dog.Eat();
        pomerian.Eat();

    }
}