class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap diem cua ban: ");
        string gradle = Console.ReadLine();
        string result = gradle switch
        {
            "A" => "Xuat sac",
            "B" => "Gioi",
            "C" => "Trung Binh",
            "D" => "Yeu",
            _ => "Khong hop le"
        };
        Console.WriteLine(result);
    }
}