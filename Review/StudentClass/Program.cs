using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] names = { "Andrey", "Vladi", "Martin", "Pavel", "Boris" };

        Student[] students = new Student[names.Length];

        Random x = new Random();

        for(int i = 0; i < students.Length; i++)
        {
            if(i%2 == 0)
            {
                students[i] = new Student(names[i], 1, x.Next(0, 101));
            }
            else
            {
                students[i] = new Student(names[i], 1);
            }
        }
        
        foreach(Student student in students){
            Console.WriteLine(student.evaluate());
        }
    }
}

public class Student{ 

    private string name;
    private int section;
    private int finalGrade;
    private static List<int> allGrades = new List<int>();
    public Student(string name, int section, int finalGrade)
    {
        this.name = name;
        this.section = section;
        this.finalGrade = finalGrade;
        allGrades.Add(finalGrade);
    }
    public Student(string name, int section)
    {
        this.name = name;
        this.section = section;
    }

    public string evaluate()
    {
        if (finalGrade == 0)
        {
            return $"I am {name} and I haven't taken the test";
        }
        string group;

        if (finalGrade <= 35)
        {
            group = "poor";
        }
        else if (finalGrade <= 50)
        {
            group = "satisfactory";
        }
        else if (finalGrade <= 70)
        {
            group = "good";
        }
        else if (finalGrade <= 85)
        {
            group = "very good";
        }
        else if (finalGrade <= 95)
        {
            group = "excellent";
        }
        else
        {
            group = "exceed expectations";
        }
        return $"Hello my name is {name} I am a student in section {section} and my final grade is {finalGrade}. My group is {group} and the average of all grades is {gradeAverage()}.";
    }
    private float gradeAverage(){
        int sum = 0;
        foreach(int grade in allGrades){
            sum += grade;
        }
        return (float)sum / allGrades.Count;
    }
}