namespace Task13
{
    internal class Program
    {
        static void Main()
        {
            string sentence = "aaa bb cc d eeeee fffffff;";

            string[] words = SplitStringIntoWords(sentence);

           
            Console.WriteLine(sentence);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static string[] SplitStringIntoWords(string sentence)
        {
            return sentence.Split(' ');
        }
    }
}
