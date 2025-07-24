class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so bat ky: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine(number + " la so nguyen to.");
        }
        else
        {
            Console.WriteLine(number + " khong la so nguyen to.");
        }
    }

    public static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}