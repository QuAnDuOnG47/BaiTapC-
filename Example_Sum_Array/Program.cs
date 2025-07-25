class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("Cac so trong mang la:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Tong cac so trong mang la: " + sum);
    }
}
