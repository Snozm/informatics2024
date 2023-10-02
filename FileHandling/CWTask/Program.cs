using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        string path = @"H:\informatics2024\FileHandling\Test.txt";
        if (!File.Exists(path))
        {
            File.Create(path);
        }


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(File.Exists(path) ? "File exists" : "New file");
        Console.ResetColor();

        string[] data = { "name", "last", "age", "hobbies", "uni" };
        Console.WriteLine("Enter name: ");
        data[0] = Console.ReadLine();
        Console.WriteLine("Enter last name");
        data[1] = Console.ReadLine();
        Console.WriteLine("Enter age");
        data[2] = Console.ReadLine();
        Console.WriteLine("Enter hobbies");
        data[3] = Console.ReadLine();
        Console.WriteLine("Enter university");
        data[4] = Console.ReadLine();
        File.WriteAllLines(path, data);
    }
}