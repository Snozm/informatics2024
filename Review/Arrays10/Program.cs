using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter length:");
        int length = int.Parse(Console.ReadLine());
        int number = 0;
        Random x = new Random();
        for(int i = 0; i < length; i++){
            int random = x.Next(1, 11);
            numbers.Add(number + random);
            number += random;
            Console.WriteLine(numbers[i]);
        }
        int search;
        do{
            Console.WriteLine("Enter number to search:");
            search = int.Parse(Console.ReadLine());
        }while(!numbers.Contains(search));

        int minIndex = 0;
        int maxIndex = length - 1;
        while(true){
            int index = (minIndex + maxIndex) / 2;
            if(numbers[index] == search){
                Console.WriteLine(index);
                break;
            }
            else if(numbers[index] > search){
                maxIndex = index;
            }
            else{
                minIndex = index;
            }
        }

    }
}