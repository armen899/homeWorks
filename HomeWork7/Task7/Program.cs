namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            int total = 0;

            for (int i = 2; i <= userNumber; i++)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine("Sum is: " + total);
        }
    }
}
