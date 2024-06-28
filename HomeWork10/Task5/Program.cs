using System.Text;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdef";
            var str1 = ReverseString(str);

            Console.WriteLine(str1);
        }

        static string ReverseString(string str)
        {
            StringBuilder reversedString = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString.Append(str[i]);
            }
            return reversedString.ToString();
        }
    }
}
