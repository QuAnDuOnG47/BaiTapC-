class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so tien USD:");
        float usd = float.Parse(Console.ReadLine());
        float vnd = usd * 23000;
        Console.WriteLine("Gia tri VND la: " + vnd + " VND");
    }
}
