using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, School> schools = new Dictionary<string, School>();

        schools.Add("ACS", new School());
        string[] courses = { "math", "physics", "informatics" };
        schools["ACS"].AddStudent("Andrey", courses);
        schools["ACS"].AddStudent("Vladi", courses);
        courses[2] = "IT";
        schools["ACS"].AddStudent("Martin", courses);

        schools.Add("SMG", new School());
        string[] smgCourses = { "math", "physics", "informatics", "art" };
        schools["SMG"].AddStudent("Daniel", smgCourses);

        foreach (KeyValuePair<string, School> school in schools)
        {
            Console.WriteLine($"Name of school: {school.Key}");
            foreach(KeyValuePair<string, string[]> student in school.Value.GetStudents())
            {
                Console.WriteLine($"Student name: {student.Key}");
                Console.WriteLine("Courses taken: ");
                foreach(string course in student.Value)
                {
                    Console.Write($"{course} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
    public Dictionary<string, string[]> GetStudents()
    {
        return students;
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