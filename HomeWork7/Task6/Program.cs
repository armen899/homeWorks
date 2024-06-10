namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number");
            string userInput = Console.ReadLine();
            int stringLength = userInput.Length;
            int userNumber = int.Parse(userInput);
            int total = 0;

            for (int i = 0; i < stringLength; i++)
            {
                int currentNumber = int.Parse(userInput[i].ToString());
                int tmp = 1;
                for (int j = 0; j < stringLength; j++)
                {
                    tmp *= currentNumber;
                }
                total += tmp;
            }

            if (total == userNumber)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }
    }
}
