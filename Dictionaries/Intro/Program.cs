using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<int, string> d_ = new Dictionary<int, string>();
        d_.Add(1, "Programming");
        d_.Add(2, "Programming");
        d_.Add(3, "Programming");
        d_.Add(4, "Programming");
        d_.Add(5, "Programming");
        d_.Add(6, "Programming");

        foreach(KeyValuePair<int, string> item in d_){
            Console.WriteLine($"{item.Key}, {item.Value}")
        }
    }
}
