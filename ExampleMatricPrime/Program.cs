class Program()
{
    public static void Main(string[] args)
    {
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.WriteLine(a[i, j]);
            }
        }
        
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (IsPrime(a[i, j].ToString()))
                {
                    Console.WriteLine($"{a[i, j]} is a prime number.");
                }
            }
        }
    }

    static bool IsPrime(string input)
    {
        if (!int.TryParse(input, out int number))
        {
            return false;
        }

        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}