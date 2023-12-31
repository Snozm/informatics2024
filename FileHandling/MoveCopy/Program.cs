﻿using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        string path1 = @"02OCT_AndreyPetrov\Test.txt";
        string path2 = @"02OCT_AndreyPetrov2\Test.txt";

        if (!Directory.Exists(@"02OCT_AndreyPetrov"))
        {
            Directory.CreateDirectory(@"02OCT_AndreyPetrov");
        }
        if (!Directory.Exists(@"02OCT_AndreyPetrov2"))
        {
            Directory.CreateDirectory(@"02OCT_AndreyPetrov2");
        }

        if (!File.Exists(path1))
        {
            using (StreamWriter sw = File.CreateText(path1))
            {
                sw.WriteLine("This is");
                sw.WriteLine("the");
                sw.WriteLine("Classwork 3");
            }
        }

        using (StreamWriter sw = File.AppendText(path1))
        {
            sw.WriteLine("File");
            sw.WriteLine("written");
            sw.WriteLine("and moved.");
        }

        if (File.Exists(path2))	
            File.Delete(path2);

        File.Move(path1, path2);
    }
}