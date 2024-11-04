namespace Tamrin_5___Seri_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just Press Letters");
            char b;
            do
            {
                b = Console.ReadKey(true).KeyChar;
            }
            while (b != 'q' && b != 'w' && b != 'e' && b != 'r' && b != 't' && b != 'y' && b != 'u' && b != 'i' && b != 'o' && b != 'p' && b != 'a' && b != 's' && b != 'd' && b != 'f' && b != 'g' && b != 'h' && b != 'j' && b != 'k' && b != 'l' && b != 'z' && b != 'x' && b != 'c' && b != 'v' && b != 'b' && b != 'n' && b != 'm');
            Console.WriteLine();
            Console.WriteLine("You Pressed " + b);
        }
    }
}