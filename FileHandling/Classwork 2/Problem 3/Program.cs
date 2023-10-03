using System;

public class Program
{
    public static void Main()
    {

        string path = @"File_Handling";
        DirectoryInfo Dir = new DirectoryInfo(path);
        Dir.Create();

        string filePath = $"{path}\\Test.txt";

        if(!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        
        using (StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine("Appending");
            sw.WriteLine("Some");
            sw.WriteLine("Text");
        }
    }
}