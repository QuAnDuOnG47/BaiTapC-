class Student
{
    int id;
    string name;
    static string college = "ABC University";
    public  void Display()
    {
        Console.WriteLine(id + " " + name + " " + college);
    }
    public Student(int i, string n)
    {
        id = i;
        name = n;
    }
    public static void Change()
    {
        college = "Code Gym";
    }
}

class Program
{
    static void Main(string[] args)
    {
        
       Student.Change();
                             //creating objects
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            
            s1.Display();
            s2.Display();
            s3.Display();
    }
}