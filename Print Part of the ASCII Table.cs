using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            byte firstNumber = byte.Parse(Console.ReadLine());
            byte lastNumber = byte.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
