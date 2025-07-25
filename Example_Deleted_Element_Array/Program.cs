class Program
{
    static int[] arr;
    static int n;     

    static void Main(string[] args)
    {
        ImportArray();
        DeleteElement();
    }

    static void ImportArray()
    {
        Console.WriteLine("Nhap so luong phan tu cua mang: ");
        n = int.Parse(Console.ReadLine());
        arr = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mang vua nhap la: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void DeleteElement()
    {
        Console.WriteLine("Nhap so muon xoa khoi mang: ");
        int value = int.Parse(Console.ReadLine());

        // Đếm số lượng phần tử khác value
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != value)
                count++;
        }

        if (count == n)
        {
            Console.WriteLine("Khong co phan tu de xoa.");
            return;
        }

        int[] newArr = new int[count];
        int idx = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != value)
            {
                newArr[idx] = arr[i];
                idx++;
            }
        }

        Console.WriteLine("Mang sau khi xoa:");
        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write(newArr[i] + " ");
        }
    }
}