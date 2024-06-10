namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + ": " + rnd.Next(1, 100));
            }
        }
    }
}
