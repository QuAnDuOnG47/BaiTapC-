class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập số nguyên a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số nguyên b:");
        int b = Convert.ToInt32(Console.ReadLine());
       
        PrintMax(a, b);
    }

    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }
    
    public static void PrintMax(int a, int b)
    {
        Console.WriteLine($"Giá trị lớn nhất giữa {a} và {b} là: {Max(a, b)}");
    }
}