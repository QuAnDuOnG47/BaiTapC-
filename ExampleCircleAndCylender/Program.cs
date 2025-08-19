public class Circle
{
    public double Radius { get; set; }
    public string Color { get; set; }



    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"A {Color} Circle with radius={Radius}";
    }
}

public class Cylinder : Circle
{
    public double Height { get; set; }

    public Cylinder(double radius, double height, string color) : base(radius, color)
    {
        Height = height;
    }

    public double GetVolume()
    {
        return GetArea() * Height;
    }
    public double GetSurfaceArea()
    {
        return 2 * GetArea() + GetCircumference() * Height;
    }
    public override string ToString()
    {
        return $"A {Color} Cylinder with radius={Radius} and height={Height}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "red");
        Console.WriteLine(circle);
        Console.WriteLine($"Area: {circle.GetArea()}");
        Console.WriteLine($"Circumference: {circle.GetCircumference()}");

        Cylinder cylinder = new Cylinder(5.0, 10.0, "blue");
        Console.WriteLine(cylinder);
        Console.WriteLine($"Volume: {cylinder.GetVolume()}");
        Console.WriteLine($"Surface Area: {cylinder.GetSurfaceArea()}");
    }
}