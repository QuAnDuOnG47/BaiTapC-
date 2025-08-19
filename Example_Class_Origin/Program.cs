class Shap
{
    public string Name { get; set; }
    public double Area { get; set; }
    public Shap(string Name, double Area)
    {
        this.Name = Name;
        this.Area = Area;
    }
}

public class Circle : Shap
{
    public Circle(double radius) : base("Circle", Math.PI * radius * radius) { }
}
public class Square : Shap
{
    public Square(double side) : base("Square", side * side) { }
}
class Program
{
    static void Main(string[] args)
    {
        Shap circle = new Shap("Circle", 78.54);
        Shap square = new Shap("Square", 100.0);
        Console.WriteLine($"Shape: {circle.Name}, Area: {circle.Area}");
        Console.WriteLine($"Shape: {square.Name}, Area: {square.Area}");

        Circle myCircle = new Circle(5);
        Console.WriteLine($"Shape: {myCircle.Name}, Area: {myCircle.Area}");

        Square mySquare = new Square(10);
        Console.WriteLine($"Shape: {mySquare.Name}, Area: {mySquare.Area}");

        Shap shape1 = new Circle(3);
    }
}