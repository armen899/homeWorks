namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 11;

            if (x > 0)
            {
                if(x < 50)
                {
                    Console.WriteLine("The number is greater than 0 and less than 50");
                }
                else
                {
                    Console.WriteLine("The number is greater than 0 but not less than 50");
                }
            }
            else
            {
                Console.WriteLine("The number is 0 or less");
            }
        }
    }
}