namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "In 1739, John Wesley bought an old cannon foundry that had been abandoned for 23 years. He fixed it up and turned it into a church and training center.";

            int strIndex = text.IndexOf("John");

            if(strIndex != -1)
            {
                Console.WriteLine("Index  " + strIndex);

            }
        }
    }
}