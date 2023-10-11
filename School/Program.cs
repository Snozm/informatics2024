using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        School acs = new School();
        string[] courses = { "math", "physics", "informatics" };
        acs.AddStudent("Andrey", courses);
        foreach(string course in acs.GetCourses("Andrey"))
        {
            Console.WriteLine(course);
        }
    }
}
public class School
{
    private Dictionary<string, string[]> students;

    public School() 
    {
        students = new Dictionary<string, string[]>();
    }
    public void AddStudent(string name, string[] courses) 
    {
        students.Add(name, courses);
    }
    public string[] GetCourses(string name)
    {
        foreach(KeyValuePair<string, string[]> student in students)
        {
            if(student.Key == name)
            {
                return student.Value;
            }
        }
        string[] none = { "student not found" };
        return none;
    }
}