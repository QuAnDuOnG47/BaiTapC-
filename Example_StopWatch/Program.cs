using System;

class Stopwatch
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    // Constructor không tham số
    public Stopwatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo mảng 100,000 số ngẫu nhiên
        int n = 100000;
        int[] arr = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 1000000);
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();

        // Thuật toán selection sort
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        sw.Stop();

        Console.WriteLine($"Thời gian thực thi selection sort cho 100,000 số: {sw.GetElapsedTime()} ms");
    }
}