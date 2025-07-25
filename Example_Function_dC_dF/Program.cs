class Program
{
    static void Main(string[] args)
    {
        int choice;
        double fahrenheit;
        double celsius;
        do
        {
            Console.WriteLine("Chọn loại chuyển đổi:");
            Console.WriteLine("1. Celsius sang Fahrenheit");
            Console.WriteLine("2. Fahrenheit sang Celsius");
            Console.WriteLine("3. Thoát");
            Console.Write("Nhập lựa chọn của bạn (1-3): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập nhiệt độ Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                    break;
                case 2:
                    Console.Write("Nhập nhiệt độ Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
                    break;
                case 3:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        } while (choice != 3);
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }
}