using System;

public class Program
{
    public static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 10, 9};
        Console.WriteLine(findNumber(arr));
    }
    public static int findNumber(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
            {
                return i;
            }
        }
        return -1;
    }
}