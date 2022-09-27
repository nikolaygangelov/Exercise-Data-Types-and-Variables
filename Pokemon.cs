using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int currentN = N;
            int countOfTargets = 0;
            while (currentN >= M)
            {
      
                if (N / 2 == (currentN - M))//5/2==3-2=1
                {
                    currentN = (currentN - M) / Y;
                    countOfTargets++;
                }
                else
                {
                    currentN -= M;//3,1
                    countOfTargets++;//2
                }
                
            }
            Console.WriteLine(currentN);
            Console.WriteLine(countOfTargets);
        }
    }
}
