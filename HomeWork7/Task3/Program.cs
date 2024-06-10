namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = 5;
            int index = 0;
            string userInput = "";
            int total = 0;
            Console.WriteLine("Please, enter number count "+ numbersCount);
            while (index < numbersCount)
            {
               
                userInput = Console.ReadLine();

                total += int.Parse(userInput);
                index++;
            }

            Console.WriteLine("Average of Numbers is: " + total / numbersCount);
        }
    }
}
