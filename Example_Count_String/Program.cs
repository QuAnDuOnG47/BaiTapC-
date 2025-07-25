class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap chuoi ky tu :");
        string input = Console.ReadLine();
        Console.WriteLine("Nhap ky tu can dem:");
        char characterToCount = Console.ReadKey().KeyChar;

        int count = CountCharacters(input, characterToCount);
        Console.WriteLine(); // Xuống dòng sau khi nhập ký tự
        Console.WriteLine($"So luong ky tu '{characterToCount}' trong chuoi la: {count}");
    }

    static int CountCharacters(string str, char character)
    {
        int count = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == character)
            {
                count++;
            }
        }
        return count;
    }
}