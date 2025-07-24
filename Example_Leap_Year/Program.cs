class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap nam:");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " la nam nhuan.");
        }
        else
        {
            Console.WriteLine(year + " khong la nam nhuan.");
        }
    }
}
