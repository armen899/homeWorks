namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            bool equals12 =  str1.Equals(str2);
            bool equals13 =  str1.Equals(str3);

            Console.WriteLine("Equals str1 str2 -  " + equals12);
            Console.WriteLine("Equals str1 str3 -  " + equals13);



            bool equals_12 = str1 == str2;
            bool equals_13 = str1 == str3;

            Console.WriteLine(" str1 == str2 -  " + equals_12);
            Console.WriteLine(" str1 == str3 -  " + equals_13);

        }
    }
}