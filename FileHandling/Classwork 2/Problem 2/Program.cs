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
            Console.WriteLine("Enter forbidden word:");
            string forbidden = Console.ReadLine();

            Console.WriteLine("Enter sentence:");

            string sentence = Console.ReadLine();
            foreach(string word in sentence.Split(' '))
            {
                if((word == forbidden))
                {
                    sw.WriteLine("");
                }
                else
                {
                    sw.WriteLine(word);
                }
            }
        }
    }
}