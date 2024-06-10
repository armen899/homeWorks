namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write the sentence");
            string userSentence = Console.ReadLine();
            string[] wordsArray = userSentence.Split(' ');

            Console.WriteLine(wordsArray.Length);
        }
    }
}
