namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AAA";
            string str2 = "AAA";
            string str3 = new string('A', 3);


            bool referenceEquals12 = ReferenceEquals(str1, str2);
            bool referenceEquals13 = ReferenceEquals(str1, str3);

            Console.WriteLine("ReferenceEquals str1 str2 -  " + referenceEquals12);
            Console.WriteLine("ReferenceEquals str1 str3 -  " + referenceEquals13);

        }
    }
}