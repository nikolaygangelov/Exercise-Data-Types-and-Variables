using System;

namespace fdsfsdfdsfs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int totalSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                if (quantities <= 255)
                {
                    totalSum += quantities;
                    if (totalSum > 255)
                    {
                        Console.WriteLine($"Insufficient capacity!");
                        totalSum -= quantities;
                    }
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
