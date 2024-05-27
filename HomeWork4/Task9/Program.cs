namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "HELLO";

            bool isEqual = str1 == str2;

            bool isEqualOrdinalIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);

            bool isEqualOrdinal = str1.Equals(str2, StringComparison.Ordinal);


            Console.WriteLine("isEqual - " + isEqual);
            Console.WriteLine("isEqualOrdinalIgnoreCase - " + isEqualOrdinalIgnoreCase);
            Console.WriteLine("isEqualOrdinal - " + isEqualOrdinal);
        }
    }
}