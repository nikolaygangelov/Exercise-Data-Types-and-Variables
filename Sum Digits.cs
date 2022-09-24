using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numCopy = number;
            int digitSum = 0;
            while (numCopy>0)
            {
                digitSum += numCopy % 10;
                numCopy /= 10;
            }
            Console.WriteLine(digitSum);
        }
    }
}
