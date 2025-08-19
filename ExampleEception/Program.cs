class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Nhap gia tri so nguyen a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia tri so nguyen b :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Thuong la {a/b}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("b = 0 khong hop le");
        }
    }
}