class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập số phần tử của mảng:");
        int a = int.Parse(Console.ReadLine());
        int[] arr = new int[a];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < a; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int min = FindMin(arr);
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
    }

    static int FindMin(int[] arr)
    {
        int min = arr[0];
        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}