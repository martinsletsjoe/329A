namespace _329B;

public class Class1
{
    private string _className;

    
    public Class1(string className)
    {
        _className = className;

    }

    public List<Student> _students = new List<Student>();
    public List<Subject> _Subjects = new List<Subject>();


    public void AddSubject(string subject)
    {
        _Subjects.Add(new Subject(subject));
    }

    //public void ShowSubject()
    //{
        
    //    foreach (var subject in _Subjects)
    //    {
    //        Console.WriteLine(subject._name);
    //    }
    //}

    

    public void AddStudent(string name, List<Subject> subjects)
    {
        _students.Add(new Student(name, subjects));
    }


    public void ShowStudentInfo()
    {
        
        foreach (var student in _students)
        {
           
            Console.WriteLine(student.Name);

        }
        
    }
}