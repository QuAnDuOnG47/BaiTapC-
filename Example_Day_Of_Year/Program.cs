class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap thang ban muon tinh ngay: ");
        int month = int.Parse(Console.ReadLine());
        switch (month)
        {
           case 2:
                Console.WriteLine("Thang 2 co 28 hoac 29 ngay (nam nhuan)!");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang " + month + " co 30 ngay!");
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang " + month + " co 31 ngay!");
                break;
            default:
                Console.WriteLine("Khong phai thang hop le!");
                break;
        }
    }
}