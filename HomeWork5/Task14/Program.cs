namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            if (age < 14)
            {
                Console.WriteLine("Child");
            }
            else if (age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age < 60)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
