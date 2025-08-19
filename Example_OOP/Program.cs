class Program
{
    static void Main()
    {
        var vehicle = new Vehicle("Generic Vehicle", 60);
        vehicle.DisplayInfo();
        vehicle.StartEngine();

        var car = new Car("Sports Car", 120, 2);
        car.DisplayCarInfo();
        car.StartEngine();

        // Demonstrating polymorphism
        Vehicle myCar = new Car("Luxury Car", 150, 4);
        myCar.DisplayInfo();
        myCar.StartEngine();
        // Using the CarRed class
        var carRed = new CarRed("Red Racer", 180, 2, "Red");
        carRed.DisplayCarRedInfo();
        carRed.StartEngine();
        
    }
}

public class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public virtual void StartEngine() // Sửa protected thành public
    {
        Console.WriteLine($"{Name} engine started.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, Speed: {Speed} km/h");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int speed, int numberOfDoors) : base(name, speed)
    {
        NumberOfDoors = numberOfDoors;
    }

        public void DisplayCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Name} car engine started with a roar!");
        }
    }
public class CarRed : Car
{
    public string Color ;
    public CarRed(string name, int speed, int numberOfDoors, string Color) : base(name, speed, numberOfDoors)
    {
        this.Color = Color;
    }

    public void DisplayCarRedInfo()
    {
        DisplayCarInfo();
        Console.WriteLine($"Color: {Color}");
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Name} red car engine started with a sporty sound!");
    }
}