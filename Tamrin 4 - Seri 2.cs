using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Just Press Numbers");
        char b;
        do
        {
            b = Console.ReadKey(true).KeyChar;
        }
        while (b != '0' && b != '1' && b != '2' && b != '3' && b != '4' && b != '5' && b != '6' && b != '7' && b != '8' && b != '9');
        Console.WriteLine();
        Console.WriteLine("You Pressed " + b);

    }
}
