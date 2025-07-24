class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu cao (m):");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap can nang (kg):");
        float weight = float.Parse(Console.ReadLine());

        float bmi = weight / (height * height);
        if(bmi < 18.5)
        {
            Console.WriteLine("Chi so BMI la: " + bmi + " Ban bi thieu can.");
        }
        else if(bmi < 25.0)
        {
            Console.WriteLine("Chi so BMI la: " + bmi + " Ban co can nang binh thuong.");
        }
        else if(bmi < 30.0)
        {
            Console.WriteLine("Chi so BMI la: " + bmi + " Ban bi thua can.");
        }
        else
        {
            Console.WriteLine("Chi so BMI la: " + bmi + " Ban bi beo phi.");
        }
       
    }
}
