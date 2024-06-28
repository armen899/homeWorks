namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcdef";
            string str2 = "fedcba";

            bool result = AreAnagrams(str1, str2);

            if (result)
            {
                Console.WriteLine("Are anagrams.");
            }
            else
            {
                Console.WriteLine("Are not anagrams.");
            }
        }

        static bool AreAnagrams(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[str2.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
