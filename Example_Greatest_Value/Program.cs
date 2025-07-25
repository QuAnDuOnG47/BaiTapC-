class Program
{
    static void Main(string[] args)
    {
        int size = -1; // Khởi tạo giá trị ban đầu
        int[] array;

        do
        {
            if (size < 0 || size > 20) // Sửa lại điều kiện kiểm tra
            {
                Console.WriteLine("Kích thước mảng phải nằm trong khoảng từ 0 đến 20. Vui lòng nhập lại.");
            }
            Console.Write("Nhập kích thước mảng (0-20): ");
            size = Convert.ToInt32(Console.ReadLine());
        } while (size < 0 || size > 20);

        array = new int[size];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Phần tử {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Danh sách các phần tử trong mảng:");
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[j] + "\t");
        }

        int max = array[0]; // Giả sử phần tử đầu tiên là lớn nhất
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) // So sánh với phần tử hiện tại
            {
                max = array[i]; // Cập nhật giá trị lớn nhất
            }
        }
        Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);
    }
}