namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, 4, 5, 6 };
            double average;
            CalculateAverageWithOut(ints, out average);
            Console.WriteLine("average " + average);
        }

        static void CalculateAverageWithOut(int[] ints, out double average)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            average = sum / ints.Length;
        }
    }
}
