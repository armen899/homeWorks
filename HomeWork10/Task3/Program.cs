namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, 4, 5 };
            ModifyArrayWithRef(ref ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

        }

        static void ModifyArrayWithRef(ref int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = (int)Math.Pow(ints[i], 2);
            }
        }
    }
}
