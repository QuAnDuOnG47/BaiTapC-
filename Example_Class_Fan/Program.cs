using System;

class Fan
{
    // Hằng số tốc độ
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    // Trường dữ liệu
    private int speed;
    private bool on;
    private double radius;
    private string color;

    // Getter và Setter
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Constructor không tham số
    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    // Phương thức ToString
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: speed={speed}, color={color}, radius={radius}";
        }
        else
        {
            return $"Fan is off: color={color}, radius={radius}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo Fan 1
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;

        // Tạo Fan 2
        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;

        // Hiển thị thông tin
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}