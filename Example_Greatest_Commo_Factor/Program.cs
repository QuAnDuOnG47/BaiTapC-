class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int gcd = FindGCD(a, b);
        Console.WriteLine($"UCLN cua {a} va {b} la: {gcd}");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}