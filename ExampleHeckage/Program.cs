public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap tuoi cua ban :");
       int age  = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("Ban chua truong thanh ");
        }
        else if (age >= 18 && age < 25)
        {
            Console.WriteLine("Ban da du tuoi truong thanh");
        }
        else
        {
            Console.WriteLine("Ban da qua tuoi truong thanh");
        }
        
        Console.ReadKey();
    }
}