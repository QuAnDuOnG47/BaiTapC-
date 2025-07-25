class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so cot mang 2 chieu: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so hang mang 2 chieu: ");
        int m = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, m];

        Console.WriteLine("Nhap cac phan tu cua mang: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"arr[{i},{j}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Mang da nhap la: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int max = arr[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }
}