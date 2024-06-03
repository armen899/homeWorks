namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;

            if (x >= 90)
            {
                Console.WriteLine("A");
            }
            else if (x >= 80)
            {
                Console.WriteLine("B");
            }
            else if (x >= 70)
            {
                Console.WriteLine("C");
            }
            else if (x >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}