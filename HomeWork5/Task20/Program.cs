namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 1;
            int d = 3;
            int e = 7;

            int max = a;
            int min = a;

            if (b > max)
            {
                max = b;
            }
            else if (b < min)
            {
                min = b;
            }

            if (c > max)
            {
                max = c;
            }
            else if (c < min)
            {
                min = c;
            }

            if (d > max)
            {
                max = d;
            }
            else if (d < min)
            {
                min = d;
            }

            if (e > max)
            {
                max = e;
            }
            else if (e < min)
            {
                min = e;
            }

            // Print the largest and smallest values
            Console.WriteLine("The largest number is: " + max);
            Console.WriteLine("The smallest number is: " + min);
        }
    }
}
