using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int countOfDays = 0;
            int expectedYield = startingYield;
            int totalAmountOfSpice = 0;
            while (expectedYield >= 100)
            {
                countOfDays++;
                totalAmountOfSpice += expectedYield - 26;
                expectedYield -= 10;
            }
            Console.WriteLine(countOfDays);
            Console.WriteLine(totalAmountOfSpice-26);
        }
    }
}
