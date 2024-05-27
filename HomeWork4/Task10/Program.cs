namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";


            Console.WriteLine("Hash Code str 1 -  " + string.GetHashCode(str1));
            Console.WriteLine("Hash Code str 2 -  " + string.GetHashCode(str2));
            Console.WriteLine("Hash Code str 3 -  " + string.GetHashCode(str3));
        }
    }
}