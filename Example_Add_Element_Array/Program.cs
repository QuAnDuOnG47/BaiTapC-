class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Nhap so muon chen vao mang: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vi tri muon chen (0 - " + n + "): ");
        int position = int.Parse(Console.ReadLine());

        if (position < 0 || position > n)
        {
            Console.WriteLine("Vi tri chen khong hop le.");
        }
        else
        {
            int[] newArr = new int[n + 1];
            for (int i = 0; i < position; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[position] = value;
            for (int i = position; i < n; i++)
            {
                newArr[i + 1] = arr[i];
            }

            Console.WriteLine("Mang sau khi chen:");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
    }
}