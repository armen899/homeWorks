namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 30; 
            bool hasLicense = true; 

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can drive");
                }
                else
                {
                    Console.WriteLine("Cannot drive");
                }
            }
            else
            {
                Console.WriteLine("Cannot drive");
            }
        }
    }
}