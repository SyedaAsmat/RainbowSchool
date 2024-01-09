using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public string ClassAndSection { get; set; }
}

public class Teacher
{
    public string Name { get; set; }
    public string ClassAndSection { get; set; }
    public List<Subject> Subjects { get; set; }
}

public class Subject
{
    public string Name { get; set; }
    public string SubjectCode { get; set; }
    public Teacher Teacher { get; set; }
}

public class SchoolManager
{
    private static SchoolManager _instance;
    private List<Student> _students;
    private List<Teacher> _teachers;
    private List<Subject> _subjects;

    private SchoolManager()
    {
        _students = new List<Student>();
        _teachers = new List<Teacher>();
        _subjects = new List<Subject>();
    }

    public static SchoolManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SchoolManager();
            }

            return _instance;
        }
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        _teachers.Add(teacher);
    }

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }

    public List<Student> GetStudentsInClass(string classAndSection)
    {
        return _students.FindAll(student => student.ClassAndSection == classAndSection);
    }

    public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
    {
        return _subjects.FindAll(subject => subject.Teacher.Name == teacherName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var schoolManager = SchoolManager.Instance;

        var student1 = new Student { Name = "Anjali Gupta", ClassAndSection = "10 A" };
        var student2 = new Student { Name = "Sachi Verma", ClassAndSection = "10 B" };
        var student3 = new Student { Name = "Riya Sethi", ClassAndSection = "10 A" };
        var student4 = new Student { Name = "Preeti Agarwal", ClassAndSection = "10 B" };

        var teacher1 = new Teacher { Name = "Neema Mathews", ClassAndSection = "10 A", Subjects = new List<Subject>() };
        var teacher2 = new Teacher { Name = "Anita Srivastava", ClassAndSection = "10 B", Subjects = new List<Subject>() };

        var subject1 = new Subject { Name = "English", SubjectCode = "C204", Teacher = teacher1 };
        var subject2 = new Subject { Name = "Mathematics", SubjectCode = "C203", Teacher = teacher2 };
        var subject3 = new Subject { Name = "Hindi", SubjectCode = "C202", Teacher = teacher1 };
        var subject4 = new Subject { Name = "Science", SubjectCode = "C205", Teacher = teacher2 };
        var subject5 = new Subject { Name = "Computer", SubjectCode = "E201", Teacher = teacher1 };

        schoolManager.AddStudent(student1);
        schoolManager.AddStudent(student2);
        schoolManager.AddStudent(student3);
        schoolManager.AddStudent(student4);

        schoolManager.AddTeacher(teacher1);
        schoolManager.AddTeacher(teacher2);

        schoolManager.AddSubject(subject1);
        schoolManager.AddSubject(subject2);
        schoolManager.AddSubject(subject3);
        schoolManager.AddSubject(subject4);
        schoolManager.AddSubject(subject5);

        Console.WriteLine("Students in Class 10 B:");
        foreach (var student in schoolManager.GetStudentsInClass("10 B"))
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine("\nSubjects taught by Mrs. Anita Srivastava :" +
                          "\nCode\tName");
        foreach (var subject in schoolManager.GetSubjectsTaughtByTeacher("Anita Srivastava"))
        {
            Console.WriteLine(subject.SubjectCode + "\t" + subject.Name);
        }

        Console.ReadLine();
    }
}