
namespace _11._Snowballs
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int currentSnowballSnow = 0;
            int currentSnowballTime = 0;
            int currentSnowballQuality = 0;
            BigInteger maxNumber = 0;
            for (int i = 1; i <= N; i++)

            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                BigInteger currentValue = snowballValue;
                if (currentValue > maxNumber)
                {
                    maxNumber = currentValue;
                    currentSnowballSnow = snowballSnow;
                    currentSnowballTime = snowballTime;
                    currentSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{ currentSnowballSnow} : { currentSnowballTime} = {maxNumber} ({currentSnowballQuality})");
        }
    }
}
