using System;

namespace Shape
{
    public class Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }
        public bool Filled { get; set; }

        public Circle() : this(1.0, "red", true) { }
        public Circle(double radius) : this(radius, "red", true) { }
        public Circle(double radius, string color, bool filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }

        public override string ToString()
        {
            return $"Circle(radius={Radius}, color={Color}, filled={Filled})";
        }
    }

    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle o)
        {
            if (this.Radius > o.Radius) return 1;
            else if (this.Radius < o.Radius) return -1;
            else return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComperableCircle[] circles = new ComperableCircle[]
            {
                new ComperableCircle(3.6),
                new ComperableCircle(),
                new ComperableCircle(3.5, "indigo", false)
            };
            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}