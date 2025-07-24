class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Giai phuong trinh bac nhat ax + b = c");
        Console.WriteLine("Nhap cac he so a, b, c:");
        Console.Write("Nhap a:");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhap b:");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Nhap c:");
        float c = float.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            float x = (c - b) / a;
            Console.WriteLine("Nghiem cua phuong trinh la: " + x);
        }
    }
}
