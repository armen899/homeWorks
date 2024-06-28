namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x = 'x';
            char y = 'y';
            SwapCharactersWithRef(ref x, ref y);

            Console.WriteLine("x " + x);
            Console.WriteLine("y " + y);
        }

        static void SwapCharactersWithRef(ref char x, ref char y)
        {
            x = 'w';
            y = 'r';
        }
    }
}
