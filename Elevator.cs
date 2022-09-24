using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfPeople = int.Parse(Console.ReadLine());
            short capacity = short.Parse(Console.ReadLine());

            int cast = (int)capacity;
            if (capacity >= countOfPeople)
            {
                Console.WriteLine(1);
            }
            else
            {
                if (countOfPeople % capacity == 0)
                {
                    Console.WriteLine(countOfPeople/capacity);
                }
                else
                {
                    Console.WriteLine(countOfPeople/capacity + 1);
                }
            }
        }
    }
}
