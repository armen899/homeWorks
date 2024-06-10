namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter start number");
            string startInput = Console.ReadLine();

            Console.WriteLine("Please, enter end number");
            string endInput = Console.ReadLine();

            int startInt = int.Parse(startInput);
            int endInt = int.Parse(endInput);

            for (int i = startInt; i <= endInt; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
