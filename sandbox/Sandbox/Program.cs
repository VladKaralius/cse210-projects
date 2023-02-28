using System;  
public abstract class Animal  
{  
    public abstract void MakeSound();
}  
public class Dog : Animal  
{  
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }  
}  
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
class Program{  
    public static void Main(string[] args)  
    {  
        List<Animal> animals = new List<Animal>();
        Dog dog = new Dog();  
        animals.Add(dog);
        Cat cat = new Cat();
        animals.Add(cat);
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }  
}