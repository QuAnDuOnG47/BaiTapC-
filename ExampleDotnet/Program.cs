using System;
using System.Collections.Generic;
using System.Text;

namespace mineText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
                {"*", ".", ".", "."},
                {".", ".", ".", "."},
                {".", "*", ".", "."},
                {".", ".", ".", "."}
            };

            int mapHeight = map.GetLength(0);
            int mapWidth = map.GetLength(1);

            string[,] mapReport = new string[mapHeight, mapWidth];

            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if (map[y, x] == "*")
                    {
                        mapReport[y, x] = "*";
                    }
                    else
                    {
                        int minesAround = CountMinesAround(map, y, x, mapHeight, mapWidth);
                        mapReport[y, x] = minesAround.ToString();
                    }
                }
            }

            PrintMap(mapReport, mapHeight, mapWidth);
            Console.ReadLine();
        }

        static int CountMinesAround(string[,] map, int y, int x, int mapHeight, int mapWidth)
        {
            int mines = 0;
            // Duyệt qua 8 ô xung quanh
            for (int dy = -1; dy <= 1; dy++)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    if (dy == 0 && dx == 0) continue; // Bỏ qua ô hiện tại
                    int ny = y + dy;
                    int nx = x + dx;
                    if (ny >= 0 && ny < mapHeight && nx >= 0 && nx < mapWidth)
                    {
                        if (map[ny, nx] == "*")
                        {
                            mines++;
                        }
                    }
                }
            }
            return mines;
        }

        static void PrintMap(string[,] mapReport, int mapHeight, int mapWidth)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    Console.Write(mapReport[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}