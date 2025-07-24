using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[4, 3]
        {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 9,10,11 }
        };

        // In ma trận
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Tính tổng cột thứ 2 (chỉ số 1)
        int sum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, 1];
        }

        Console.WriteLine("Tổng các phần tử ở cột thứ 2 là: " + sum);
    }
}
