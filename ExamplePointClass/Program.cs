public class Point2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point2D()
    {

    }
    public override string ToString()
    {
        return $"Point2D({X}, {Y})";
    }
}

public class Point3D : Point2D
{
    public double Z { get; set; }

    public Point3D(double x, double y, double z) : base(x, y)
    {
        Z = z;
    }

    public Point3D() : base()
    {

    }

    public override string ToString()
    {
        return $"Point3D({X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point2D point2D = new Point2D(3.0, 4.0);
        Console.WriteLine(point2D);

        Point3D point3D = new Point3D(3.0, 4.0, 5.0);
        Console.WriteLine(point3D);
    }
}