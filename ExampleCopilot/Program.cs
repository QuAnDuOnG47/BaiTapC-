using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[4, 3];
        Random rnd = new Random();
        int sum = 0;

        // Khởi tạo mảng với giá trị ngẫu nhiên và tính tổng
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = rnd.Next(0, 101);
                sum += arr[i, j];
            }
        }

        // Hiển thị mảng
        Console.WriteLine("Ma trận 4x3:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Hiển thị tổng
        Console.WriteLine("Tổng các phần tử trong mảng: " + sum);
    }
}