using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        string path = @"Students";
        DirectoryInfo Dir = new DirectoryInfo(path);
        Dir.Create();
        
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        string newPath = $"{path}\\{name}.txt";
        
        while (File.Exists(newPath))
        {
            Console.WriteLine("Student already exists. Enter new name:");
            name = Console.ReadLine();
            newPath = $"{path}\\{name}.txt";
        }

        using (StreamWriter sw = File.CreateText(newPath))
        {
            Console.WriteLine("Enter student's age:");
            string age = Console.ReadLine();
            sw.WriteLine($"Age: {age}");

            Console.WriteLine("Enter student's GPA:");
            string gpa = Console.ReadLine();
            sw.WriteLine($"GPA: {gpa}");
        }

        Console.WriteLine($"Student info for {name}:");
        using (StreamReader sr = File.OpenText(newPath))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

        Console.WriteLine("Files in the Student Folder:");
        foreach (FileInfo file in Dir.GetFiles())
        {
            Console.WriteLine(file.Name);
        }
    }
}