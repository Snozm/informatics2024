using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());

        int NFactorial = 1;
        int KFactorial = 1;
        int NMinusKFactorial = 1;

        for(int i = 2; i <= N; i++){
            NFactorial *= i;
            if(i <= K){
                KFactorial *= i;
            }
            if(i <= N - K){
                NMinusKFactorial *= i;
            }
        }
        
        Console.WriteLine(NFactorial * KFactorial / NMinusKFactorial);
    }
}