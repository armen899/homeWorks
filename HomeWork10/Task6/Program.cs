namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 7, 1, 5 };
            int max;
            var count = FindMaximumWithOut(ints, out max);

            Console.WriteLine("max " + max);
            Console.WriteLine("count " + count);
        }

        static int FindMaximumWithOut(int[] ints, out int max)
        {
            max = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
            }
            return ints.Length;
        }
    }
}
