namespace StudentLinQ;

class Program
{
    static void Main(string[] args)
    {
        var students = GetStudents();

        var enumerable = students as Student[] ?? students.ToArray();
        PrintStudent(enumerable.Where(p => p.YoB == 2002).OrderBy(s => s.Name));
        
        var studentHongKong = enumerable.FirstOrDefault(p => p.City == "HongKong" && p.YoB <= 2000);
        Print(studentHongKong);        
    }

    static void PrintStudent(IEnumerable<Student> students)
    {
        foreach (var student in students)
        {
            Print(student);
        }    
    }

    private static void Print(Student student)
    {
        Console.WriteLine($"Name: {student.Name}, City: {student.City}, YOB: {student.YoB}");
    }
    
    static IEnumerable<Student> GetStudents()
    {
        return new Student[]
        {
            new Student()
            {
                Name = "Testing",
                YoB = 2002,
                City = "Huawei"
            },
            new Student()
            {
                Name = "Testing 2",
                YoB = 1999,
                City = "HongKong"
            },
            new Student()
            {
                Name = "Testing 3",
                YoB = 2999,
                City = "HongKong"
            },
        };
    }
}