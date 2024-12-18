using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Creational.FactoryPattern;

public interface IAnimal
{
    public void Speak();
}

public class AnimalFactory
{
    public IAnimal CreateAnimal(string type)
    {
        return type switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            "lion" => new Lion(),
            _ => throw new ArgumentException("Unknown animal type")
        };
    }
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class Lion : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Roar!");
    }
}



