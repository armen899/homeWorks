namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";

            Console.WriteLine("String -  " + str);
            Console.WriteLine("Lenght - " + str.Length);
            Console.WriteLine("Uppercase - " + str.ToUpper());
            Console.WriteLine("Lowercase - " + str.ToLower());

            int strIndex = str.IndexOf("World");
            string str2 = str.Substring(strIndex);
            Console.WriteLine("Extract - " + str2);
        }
    }
}