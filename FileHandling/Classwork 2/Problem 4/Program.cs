using System;

public class Program
{
    public static void Main()
    {

        string file = @"Test.txt";

        if(!File.Exists(file))
        {
            File.Create(file);
        }
        
        using (StreamWriter sw = File.CreateText(file))
        {
            sw.WriteLine("This");
            sw.WriteLine("is");
            sw.WriteLine("text");
        }

        string newFile = @"Test2.txt";

        File.Copy(file, newFile, true);

        using (StreamReader sr = File.OpenText(newFile))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}   