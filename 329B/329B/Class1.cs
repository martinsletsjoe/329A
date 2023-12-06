namespace _329B;

public class Class1
{
    public string _className;

    
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

    

    public void AddStudent(string name)
    {
        _students.Add(new Student(name));
    }


    public void ShowStudentInfo()
    {
        Console.Clear();
        for (var index = 0; index < _students.Count; index++)
        {
            var student = _students[index];
            var subjects = _Subjects[index];
            Console.WriteLine(student.Name +" " + subjects.Name);
        }
    }
}