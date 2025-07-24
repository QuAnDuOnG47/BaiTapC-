class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so tien gui ngan hang: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap lai suat (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so thang gui: ");
        int months = Convert.ToInt32(Console.ReadLine());

        double totalInterset = 0;
        for (int i = 0; i < month; i++)
        {
            totalInterset += principal * (rate / 100) / 12;
        }
        double totalAmount = principal + totalInterset;
        Console.WriteLine("So tien lai nhan duoc sau " + months + " thang la: " + totalInterset);
        Console.WriteLine("Tong so tien sau " + months + " thang la: " + totalAmount);
    }
}