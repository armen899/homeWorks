namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sumInt, productInt;
            GetSumAndProduct(2, 3, out sumInt, out productInt);

            Console.WriteLine("sumInt " + sumInt);
            Console.WriteLine("productInt " + productInt);
        }

        static void GetSumAndProduct(int int1, int int2, out int sumInt, out int productInt)
        {
            sumInt = int1 + int2;
            productInt = int1 * int2;
        }
    }
}
