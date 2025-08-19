public class Shape
{
    public string Color { get; set; }
    public bool Filled { get; set; }

    public Shape()
    {
        Color = "Green";
        Filled = true;
    }

    public Shape(string color, bool filled)
    {
        Color = color;
        Filled = filled;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"A Shape with color of {Color} and {(Filled ? "filled" : "not filled")}");
    }

    public override string ToString()
    {
        return $"A Shape with color of {Color} and {(Filled ? "filled" : "not filled")}";
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
        Radius = 1.0;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public void DisplayCircleInfo()
    {
        Console.WriteLine($"A Circle with radius of {Radius}, which is a subclass of {base.ToString()}");
    }

    public override string ToString()
    {
        return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle()
    {
        Width = 1.0;
        Height = 1.0;
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(double width, double height, string color, bool filled) : base(color, filled)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public virtual void SetWidth(double width)
    {
        Width = width;
    }

    public virtual void SetLength(double length)
    {
        Height = length;
    }

    public double GetWidth()
    {
        return Width;
    }

    public double GetLength()
    {
        return Height;
    }

    public void DisplayRectangleInfo()
    {
        Console.WriteLine($"A Rectangle with width of {Width} and height of {Height}, which is a subclass of {base.ToString()}");
    }

    public override string ToString()
    {
        return $"A Rectangle with width={Width} and height={Height}, which is a subclass of {base.ToString()}";
    }
}

public class Square : Rectangle
{
    public Square() : base()
    {
    }

    public Square(double side) : base(side, side)
    {
    }

    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
    }

    public double GetSide()
    {
        return GetWidth();
    }

    public void SetSide(double side)
    {
        base.SetWidth(side);
        base.SetLength(side);
    }

    public override void SetWidth(double width)
    {
        SetSide(width);
    }

    public override void SetLength(double length)
    {
        SetSide(length);
    }

    public override string ToString()
    {
        return $"A Square with side={GetSide()}, which is a subclass of {base.ToString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.3, 5.8);
        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.5, 3.8, "orange", true);
        Console.WriteLine(rectangle);

        Square square = new Square();
        Console.WriteLine(square);

        square = new Square(2.3);
        Console.WriteLine(square);

        square = new Square(5.8, "yellow", true);
        Console.WriteLine(square);
    }
}