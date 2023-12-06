namespace _329B;

public class Student
{
    public string Name;
    public List<Subject> SubjectNames;

    public Student(string name, List<Subject> subjectNames= null)
    {
        Name = name;
        SubjectNames = subjectNames;
    }
}

/*
 *     public string subjects;
   public string weekplan;
*/