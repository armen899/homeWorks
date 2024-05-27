namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, World!";
            string str2 = "";
            string str3 = "          ";

            if (string.IsNullOrEmpty(str1)) 
            {
                Console.WriteLine("str1 null or empty");
            }


            if (string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("str2 null or empty");
            }
            
                        
            if (string.IsNullOrEmpty(str3))
            {
                Console.WriteLine("str3 null or empty");
            }


            if (string.IsNullOrWhiteSpace(str1))
            {
                Console.WriteLine("str1 null or White Space");
            }


            if (string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("str2 null or White Space");
            }


            if (string.IsNullOrWhiteSpace(str3))
            {
                Console.WriteLine("str3 null or White Space");
            }

            Console.ReadKey();
        }
    }
}