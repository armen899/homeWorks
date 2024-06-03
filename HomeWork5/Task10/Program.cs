namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30; 
            int b = 40;
            int c = 5;

            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("The largest number is: " + a);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine("The largest number is: " + b);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
        }

    }
}