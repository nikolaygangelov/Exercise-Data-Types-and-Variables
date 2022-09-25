using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxNumber = double.MinValue;
            double currentVolume = 0;
            string currentModel = string.Empty;
            bool isBiggest = true;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;//100,400,300
                currentVolume = volume;//100,400,300
                if (currentVolume > maxNumber)
                {
                    maxNumber = currentVolume;//100,400
                    currentModel = model;

                }
            }
            Console.WriteLine(currentModel);
        }
    }
}
