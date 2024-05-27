namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "apple,banana,orange";

            string[] fruits = str.Split(",");

            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);

        }
    }
}