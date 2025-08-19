class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Alice", 20, 3.5, 3.0);
        Student student2 = new Student("Bob", 22, 3.8, 3.2);        
        Console.WriteLine($"Student 1: {student1.Name}, Age: {student1.Age}, GPA: {student1.GPA}, MatchGPA: {student1.MatchGPA}");
        Console.WriteLine($"Student 2: {student2.Name}, Age: {student2.Age}, GPA: {student2.GPA}, MatchGPA: {student2.MatchGPA}");
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }

    public double MatchGPA { get; set; }

    public Student(string name, int age, double gpa , double matchGPA )
    {
        Name = name;
        Age = age;
        GPA = gpa;
        MatchGPA = matchGPA;

    }

    
}