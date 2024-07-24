public class Program
{
    public static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Cat(),
            new Bird()
        };

        foreach (var animal in animals)
        {
            // prints meowing and chirping
            animal.MakeSound();
        }

        // example of using an interface for polymorphism
        IAnimal Ianimal = new Dog();
       
        // prints "Woof Woof"
        Ianimal.MakeSound();
    }
}

// base class
public class Animal
{
    // virtual method to allow overriding
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

// child class Cat
public class Cat : Animal
{
    // overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow");
    }
}

// child class Bird
public class Bird : Animal
{
    // overriding the base class method
    public override void MakeSound()
    {
        Console.WriteLine("Chirp Chirp");
    }
}