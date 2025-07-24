class Program()
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Nhan so phan tu cua mang 2 chieu :");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        if (n <= 0)
        {
            Console.WriteLine("So phan tu phai lon hon 0.");
            return;
        }

        Console.WriteLine("Nhap cac phan tu cua mang 2 chieu :");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Mang 2 chieu vua nhap la :");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tong cac phan tu tren duong cheo chinh la :");
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i, i];
        }
        Console.WriteLine(sum);
    }
}