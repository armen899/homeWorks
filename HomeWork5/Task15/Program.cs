namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            int c = 30;
            int d = 4;

            if (a >= b && a >= c && a >= d)
            {
                Console.WriteLine("a: " + a);
            }
            else if (b >= a && b >= c && b >= d)
            {
                Console.WriteLine("b: " + b);
            }
            else if (c >= a && c >= b && c >= d)
            {
                Console.WriteLine("c: " + c);
            }
            else
            {
                Console.WriteLine("d: " + d);
            }
        }
    }
}
