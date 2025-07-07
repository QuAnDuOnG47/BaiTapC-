public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhan ban kinh hinh tron : ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double pre = 2 * Math.PI * radius;
        Console.WriteLine("Dien tich hinh tron la: " + area);
        Console.WriteLine("Chu vi hinh tron la: " + pre);

    }
}