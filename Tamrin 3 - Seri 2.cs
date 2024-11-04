using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} Is in Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{n} Isn't in Fibonacci.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1, temp;

        if (n < 0)
            return false;

        while (b < n)
        {
            temp = b;
            b = a + b;
            a = temp;
        }

        return b == n;
    }
}
