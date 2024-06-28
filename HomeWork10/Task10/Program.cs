namespace Task10
{
    internal class Program
    {
        static void Main()
        {
            int n = 12;
            GeneratePrimes(n);
        }

        static void GeneratePrimes(int n)
        {
            if (n <= 0)
            {
                return;
            }

            int count = 0;
            int number = 2;

            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }

            Console.WriteLine();
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
