using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int task
        do{
            Console.WriteLine("Choose a task: \n Task 1: reverse an integer \n Task 2: calculate an average \n Task 3: solve a linear equation")
            int task = int.Parse(Console.ReadLine());
        }while(task < 1 || task > 3);

        switch(task){
            case 1: 
                int num;
                do{
                    Console.WriteLine("Enter an integer: ");
                    num = int.Parse(Console.ReadLine());
                }while(num < 1 && num > 50000000);
                Console.WriteLine("Reversed: " + reverse(num).ToString());
                break;

            case 2: 
                Console.WriteLine("Enter length: ");
                int length = int.Parse(Console.ReadLine());
                int[] arr = new int[length];
                for(int i = 0; i < length; i++){
                    Console.WriteLine("Enter a number: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Average: " + average(arr));
                break;

            case 3: 
                int a;
                do{
                    Console.WriteLine("Enter a: ");
                    a = int.Parse(Console.ReadLine());
                }while(a == 0);
                int b;
                do{
                    Console.WriteLine("Enter b: ");
                    b = int.Parse(Console.ReadLine());
                }while(b == 0);
                Console.WriteLine("x = " + solve(a, b));
                break;
            default:
                break; 
        }
    }
    public static int reverse(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed *= 10
            reversed += num % 10;
            num /= 10;
        }
        return reversed;
    }
    public static double average(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }
    public static double solve(int a, int b)
    {
        return (double)-b / a;
    }
}