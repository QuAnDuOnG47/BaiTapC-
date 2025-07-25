class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong so nguyen to muon in :");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int num = 2;
        while (count < n)
        {
            if (IsPrime(num))
            {
                
                Console.WriteLine("So thu " + (count + 1) + " la: " + num);
                count++;
            }
            num++;
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}