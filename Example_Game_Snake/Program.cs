using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int width = 40;
    static int height = 20;
    static int score = 0;
    static bool gameOver = false;
    static int foodX, foodY;
    static Random rand = new Random();

    enum Direction { Up, Down, Left, Right }
    static Direction dir = Direction.Right;

    static List<int> snakeX = new List<int>();
    static List<int> snakeY = new List<int>();

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        StartGame();

        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(100); // tốc độ game
        }

        Console.SetCursorPosition(0, height + 2);
        Console.WriteLine("Game Over! Score: " + score);
        Console.ReadKey();
    }

    static void StartGame()
    {
        snakeX.Clear();
        snakeY.Clear();
        snakeX.Add(width / 2);
        snakeY.Add(height / 2);
        dir = Direction.Right;
        score = 0;
        gameOver = false;
        GenerateFood();
    }

    static void Draw()
    {
        Console.SetCursorPosition(0, 0);
        // Vẽ tường trên
        for (int i = 0; i < width + 2; i++) Console.Write("#");
        Console.WriteLine();

        // Vẽ thân rắn, thức ăn, tường bên
        for (int y = 0; y < height; y++)
        {
            Console.Write("#");
            for (int x = 0; x < width; x++)
            {
                if (x == snakeX[0] && y == snakeY[0])
                    Console.Write("■"); // đầu rắn
                else if (x == foodX && y == foodY)
                    Console.Write("■"); // thức ăn
                else
                {
                    bool isBody = false;
                    for (int k = 1; k < snakeX.Count; k++)
                    {
                        if (x == snakeX[k] && y == snakeY[k])
                        {
                            Console.Write("■");
                            isBody = true;
                            break;
                        }
                    }
                    if (!isBody) Console.Write(" ");
                }
            }
            Console.WriteLine("#");
        }

        // Vẽ tường dưới
        for (int i = 0; i < width + 2; i++) Console.Write("#");
        Console.WriteLine();
        Console.WriteLine("Score: " + score);
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (dir != Direction.Down) dir = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (dir != Direction.Up) dir = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (dir != Direction.Right) dir = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (dir != Direction.Left) dir = Direction.Right;
                    break;
            }
        }
    }

    static void Logic()
    {
        // Di chuyển thân rắn
        for (int i = snakeX.Count - 1; i > 0; i--)
        {
            snakeX[i] = snakeX[i - 1];
            snakeY[i] = snakeY[i - 1];
        }

        // Di chuyển đầu rắn
        switch (dir)
        {
            case Direction.Up: snakeY[0]--; break;
            case Direction.Down: snakeY[0]++; break;
            case Direction.Left: snakeX[0]--; break;
            case Direction.Right: snakeX[0]++; break;
        }

        // Kiểm tra va chạm tường
        if (snakeX[0] < 0 || snakeX[0] >= width || snakeY[0] < 0 || snakeY[0] >= height)
        {
            gameOver = true;
            return;
        }

        // Kiểm tra va chạm thân
        for (int i = 1; i < snakeX.Count; i++)
        {
            if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
            {
                gameOver = true;
                return;
            }
        }

        // Ăn thức ăn
        if (snakeX[0] == foodX && snakeY[0] == foodY)
        {
            score += 10;
            snakeX.Add(snakeX[snakeX.Count - 1]);
            snakeY.Add(snakeY[snakeY.Count - 1]);
            GenerateFood();
        }
    }

    static void GenerateFood()
    {
        while (true)
        {
            foodX = rand.Next(0, width);
            foodY = rand.Next(0, height);
            bool onSnake = false;
            for (int i = 0; i < snakeX.Count; i++)
            {
                if (foodX == snakeX[i] && foodY == snakeY[i])
                {
                    onSnake = true;
                    break;
                }
            }
            if (!onSnake) break;
        }
    }
}
 