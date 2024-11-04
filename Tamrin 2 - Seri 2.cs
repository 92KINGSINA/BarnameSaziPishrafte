using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number (n): ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        Console.WriteLine($"Palindromic numbers between {n} and {m}:");

        for (int i = n; i <= m; i++)
        {
            if (IsPalindrome(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        char[] charArray = strNumber.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumber = new string(charArray);
        return strNumber == reversedNumber;
    }
}