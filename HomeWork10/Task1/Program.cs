namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = { 7.3, 1.3, 5.6 };
            double min;
            FindMinimumWithOut(doubles, out min);

            Console.WriteLine("minnnnnn " + min);
        }

        static void FindMinimumWithOut(double[] doubles, out double min)
        {
            min = doubles[0];
            for (int i = 1; i < doubles.Length; i++)
            {
                if (doubles[i] < min)
                {
                    min = doubles[i];
                }

            }
        }
    }
}
