public class Program
{
    public static void Main(string[] args)
    {
        float width, height;
        Console.Write("Hay nhap gia tri chieu rong:");
        width = Convert.ToSingle(Console.ReadLine());
        Console.Write("Hay nhap gia tri chieu cao:");
        height = Convert.ToSingle(Console.ReadLine());
        float area = width * height;
        Console.WriteLine($"Gia tri dien tich la : {area}");
    }
}