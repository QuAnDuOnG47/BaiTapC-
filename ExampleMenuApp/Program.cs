﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap vao 1 so : ");
        Console.WriteLine("1. Hien thi hinh tam giac sao"); 
        Console.WriteLine("2. Hien thi hinh chu nhat sao");
        Console.WriteLine("3. Hien thi hinh vuong sao");
        Console.WriteLine("4. Hien thi hinh tron sao");
        Console.WriteLine("0. Thoat chuong trinh");
        int choice = -1;
        while (choice != 0)
        {
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("*");
                     Console.WriteLine("**");
                      Console.WriteLine("***");
                       Console.WriteLine("****");
                        Console.WriteLine("******");
                    break;
                case 2:
                    Console.WriteLine("******");
                     Console.WriteLine("******");
                      Console.WriteLine("******");
                       Console.WriteLine("******");
                        Console.WriteLine("******");
                    break;
                case 3:
                    Console.WriteLine("********");
                    Console.WriteLine("*      *");
                    Console.WriteLine("*      *");
                    Console.WriteLine("*      *");
                    Console.WriteLine("********");
                    break;
                    case 4:
                    int radius = 5;
                    double thickness = 0.4;
                    char symbol = '*';

                    double rIn = radius - thickness, rOut = radius + thickness;
                    for (double y = radius; y >= -radius; --y)
                    {
                        for (double x = -radius; x < rOut; x += 0.5)
                        {
                            double value = x * x + y * y;
                            if (value >= rIn * rIn && value <= rOut * rOut)
                                Console.Write(symbol);
                            else
                                Console.Write(' ');
                        }
                        Console.WriteLine();
                    }
                    break;
                    case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le, vui long chon lai.");
                    break;
            }
        }
    }
}