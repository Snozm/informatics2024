using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = 1;
        int second = 0;
        int sum = 0;

        for(int i = 0; i < n; i++){
            if(i == 0){
                Console.Write(0);
                continue;
            }
            sum = first + second;
            first = second;
            second = sum;
            Console.Write($", {sum}");
        }
    }
}