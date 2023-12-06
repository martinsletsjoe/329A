namespace _329B;

public class Student
{
    public string Name;
    public List<Subject> StandardSubjects;
    public List<Subject> UniqueSubjects;

    public Student(string name, List<Subject> standardSubjects = null, List<Subject> uniqueSubjects = null)
    {
        Name = name;
        StandardSubjects = standardSubjects ?? new List<Subject>();
        UniqueSubjects = uniqueSubjects ?? new List<Subject>();
    }

}

/*
 *     public string subjects;
   public string weekplan;
*/