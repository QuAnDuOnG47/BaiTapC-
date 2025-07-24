class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("tinh tong so nguyen to trong day so nguyen a, b: ");
        Console.WriteLine("Nhap so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        if (a < 0 || b < 0)
        {
            Console.WriteLine("Khong hop le");
            return;
        }
        else if (a == 0 && b == 0)
        {
            Console.WriteLine("Khong ton tai co so nguyen to nao");
            return;
        }
        else if (a > b)
        {
            Console.WriteLine("Khong ton tai so nguyen to nao");
            return;
        }
        else if (a == b)
        {
            if (IsPrime(a))
            {
                Console.WriteLine(a);
                sum += a;
            }
            else
            {
                Console.WriteLine("Khong co so nguyen to nao");
            }
        }
        else
        {
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Tong so nguyen to: " + sum);
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}