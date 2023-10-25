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
            foreach (KeyValuePair<string, string[]> student in school.Value.GetStudents())
            {
                Console.WriteLine($"Student name: {student.Key}");
                Console.WriteLine("Courses taken: ");
                foreach (string course in student.Value)
                {
                    Console.Write($"{course} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
public class Library
{
    private Dictionary<string, string> books;
    private Dictionary<string, Dictionary<string, DateTime>> borrowers;

    public Library()
    {
        books = new Dictionary<string, string>();
        borrowers = new Dictionary<string, DateTime>();
    }
    public void AddBook(string name)
    {
        if (books.ContainsKey(name))
        {
            books[name] = "avaliable";
            return;
        }
        books.Add(name, "avaliable");
    }
    public void BorrowBook(string borrower, string book)
    {
        if (books.ContainsKey(book))
        {
            books[book] = borrower;
            if (borrowers.ContainsKey(borrower))
            {
                DateTime now = DateTime.Now;
                DateTime monthDue = (now.Month + 2) % 12 + 1; //books due in 2 months, so check if month is valid and add 1 to return to 1-12 range
                borrowers[borrower].Add(book, new Datetime(now.Year, monthDue, 1);
            }
            return;
        }
        Console.WriteLine("Book isn't in stock.")
    }
    public string[] GetCourses(string name)
    {
        foreach (KeyValuePair<string, string[]> student in students)
        {
            if (student.Key == name)
            {
                return student.Value;
            }
        }
        string[] none = { "student not found" };
        return none;
    }
}