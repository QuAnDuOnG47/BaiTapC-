public abstract class BaseClass
{
    public abstract void AbstractMethod();
}

public class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("This is the implementation of the abstract method.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DerivedClass derived = new DerivedClass();
        derived.AbstractMethod(); // Output: This is the implementation of the abstract method.
    }
}
