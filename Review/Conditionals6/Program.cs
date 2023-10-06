using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a: ax^2");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: bx");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: c");
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4*a*c;

        if(D < 0){
            Console.WriteLine("No real roots");
        }
        else if(D == 0){
            Console.WriteLine($"x1 = x2 = {-b / (2 * a)}");
        }
        else{
            Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
            Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
        }
    }
}