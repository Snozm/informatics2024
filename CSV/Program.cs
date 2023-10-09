﻿using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections; 
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader("H:\\informatics2024\\CSV\\Students.csv"))
            
            using (var csv =   new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Data>().ToList();


                var queryOne = from record in records
                               where record.gender == "Male" && record.university.Contains("Moscow")
                               select record;

                Console.WriteLine("Male students from Moscow:");
                if(queryOne.Count() == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var item in queryOne)
                    {
                        Console.WriteLine(item.first_name);
                    }
                }

                var queryTwo = from record in records
                               orderby record.GPA 
                               select record;

                Console.WriteLine("Students sorted by GPA:");
                foreach (var item in queryTwo)
                {
                    Console.WriteLine($"{item.first_name}: GPA: {item.GPA}");
                }

                var queryThree = from record in records
                               where record.email.Contains("@mit.edu") || record.email.Contains("@berkley.edu") 
                               select record;

                Console.WriteLine("Students with MIT or Berkley emails:");
               if(queryThree.Count() == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var item in queryThree)
                    {
                        Console.WriteLine(item.first_name);
                    }
                }

                var queryFour = from record in records
                               where record.gender == "Female" && float.Parse(record.GPA) >= 4.0 
                               select record;

                Console.WriteLine("Female students with GPA of 4.0 or higher:");
                if(queryFour.Count() == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var item in queryFour)
                    {
                        Console.WriteLine(item.first_name);
                    }
                }
            }
        }

        class Data
        {
            public int id { get; set; }
            public string first_name { get; set; }              
            public string last_name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string university { get; set; }
            public string GPA { get; set; }


        }
    }
}