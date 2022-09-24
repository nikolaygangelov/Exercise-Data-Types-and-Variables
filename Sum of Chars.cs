using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char? character = null;
            int sumOfAscii = 0;
            for (int i = 1; i <= n; i++)
            {
                character = char.Parse(Console.ReadLine());
                sumOfAscii += (int)character;
            }
            Console.WriteLine($"The sum equals: {sumOfAscii}");
        }
    }
}
