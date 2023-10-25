using System;
using System.Collections;
using System.Numerics;

public class Program
{
    public static Hashtable fib = new Hashtable();
    public static void Main(string[] args)
    {
        fib.Add(0, new BigInteger(1));
        fib.Add(1, new BigInteger(1));
        for (int i = 0; i < 100; ++i) {
          Console.WriteLine(callFibonacci(i));
        }
    }

    public static BigInteger callFibonacci(int n) {
      if (n < 0)
        return 1;
      if (fib.ContainsKey(n))
        return (BigInteger)fib[n];
      BigInteger res = new BigInteger(0);
      if (!fib.ContainsKey(n - 1))
        fib.Add(n - 1, callFibonacci(n - 1));
      res += (BigInteger)fib[n - 1];
      if (!fib.ContainsKey(n - 2))
        fib.Add(n - 2, callFibonacci(n - 2));
      res += (BigInteger)fib[n - 2];
      fib.Add(n, res);
      return res;
    }
}
