namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int rnd = randomNumber.Next(1, 100);
            Console.WriteLine("Please, enter number");
            string userInput = "";
            int userInt = 0;

            while (userInt != rnd)
            {
                userInput = Console.ReadLine();
                userInt = int.Parse(userInput);

                if (userInt < rnd)
                {
                    Console.WriteLine("too low");
                }
                else if (userInt > rnd)
                {
                    Console.WriteLine("too high");
                }
            }

            Console.WriteLine("guessed");
        }
    }
}
