using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 3, 1, 6, 4, 20, 12 };

            int sum;
            double average;
            int max;

            CalculateStatistics(ints, out sum, out average, out max);
          
            Console.WriteLine($"sum {sum}");
            Console.WriteLine($"average {average}");
            Console.WriteLine($"max {max}");
        }


        static void CalculateStatistics(int[] ints, out int sum, out double average, out int max)
        {
            max = ints[0];
            sum = 0;
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
                sum += ints[i];
            }
            average = sum/ints.Length;
        }
    }
}
