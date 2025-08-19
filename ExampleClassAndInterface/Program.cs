public abstract class Animal
{

    public abstract void MakeSound();

}

public class Chicken : Animal , Edible
{
    public override void MakeSound()
    {
        Console.WriteLine("Cluck");
    }

    public string HowToEat()
    {
        return "Chicken: Fry it!";
    }
}

public class Tiger : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }

         Fruit[] fruits = new Fruit[2];
    fruits[0] = new Orange();
    fruits[1] = new Apple();
    foreach (Fruit fruit in fruits)
    {
      Console.WriteLine(fruit.HowToEat());
    }
    }
}

public interface Edible
{
    public string HowToEat();
}

public abstract class Fruit : Edible {
  public abstract string HowToEat();
}

public class Apple : Fruit
{
    public override string HowToEat()
    {
        return "Apple could be slided";
    }
}

public class Orange : Fruit
{
  public override string HowToEat()
  {
    return "Orange could be juiced";
  }
}