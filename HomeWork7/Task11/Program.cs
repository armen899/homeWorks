namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new String[3] { "Rock", "Paper", "Scissors" };
            Console.WriteLine("User input Rock, Paper, Scissors");

            string userInput = Console.ReadLine();

            Random rand = new Random();
            string pcInput = str[rand.Next(0, 2)];

            Console.WriteLine("comp: " + pcInput);

            if (pcInput == userInput)
            {
                Console.WriteLine("Havasarazor eq");
            }
            else
            {
                switch (userInput)
                {
                    case "Rock":
                        if (pcInput == "Scissors")
                        {
                            Console.WriteLine("krel eq");
                        }
                        else
                        {
                            Console.WriteLine("krvar");
                        }
                        break;
                    case "Paper":
                        if (pcInput == "Rock")
                        {
                            Console.WriteLine("krel eq");
                        }
                        else
                        {
                            Console.WriteLine("krvar");
                        }
                        break;
                    case "Scissors":
                        if (pcInput == "Paper")
                        {
                            Console.WriteLine("krel eq");
                        }
                        else
                        {
                            Console.WriteLine("krvar");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}
