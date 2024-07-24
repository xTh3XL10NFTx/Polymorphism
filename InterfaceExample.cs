// Interface
public interface IAnimal
{
    void MakeSound();
}

// Class Dog implementing IAnimal
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof Woof");
    }
}