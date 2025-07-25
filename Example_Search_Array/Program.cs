class Program
{
    static void Main(string[] args)
    {

        string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
        Console.WriteLine("Nhap ten sinh vien muon tim :");
        string name = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(name))
            {
                Console.WriteLine("Vi tri cua sinh vien " + name + " la : " + (i + 1) + " trong danh sach");
                found = true;
                break;
            }
        }

        if (found != true)
        {
            Console.WriteLine("Sinh vien " + name + " khong ton tai trong danh sach.");
        }
       
        

    }

    }

