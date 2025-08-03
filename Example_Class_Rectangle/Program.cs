using System;

class Program
{
    static void Main(string[] args)
    {
        double width, height;

        Console.WriteLine("Nhap chieu rong hinh chu nhat:");
        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.WriteLine("Gia tri khong hop le. Nhap lai chieu rong (>0):");
        }

        Console.WriteLine("Nhap chieu dai hinh chu nhat:");
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Gia tri khong hop le. Nhap lai chieu dai (>0):");
        }

        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine(rectangle.Display());
        Console.WriteLine($"Dien tich hinh chu nhat: {rectangle.Area()}");
        Console.WriteLine($"Chu vi hinh chu nhat: {rectangle.Perimeter()}");
    }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Area()
    {
        return this.Width * this.Height;
    }

    public double Perimeter()
    {
        return 2 * (this.Width + this.Height);
    }

    public string Display()
    {
        return $"Rectangle{{width={Width}, height={Height}}}";
    }
}