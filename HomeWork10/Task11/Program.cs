﻿namespace Task11
{
    internal class Program
    {
        static void Main()
        {
            string name = "John Doe";
            int age = 25;

            var personInfo = GetPersonInfo(name, age);

            Console.WriteLine($"Name: {personInfo.Item1}");
            Console.WriteLine($"Age: {personInfo.Item2}");
            Console.WriteLine($"Is Adult: {personInfo.Item3}");
        }

        static (string, int, bool) GetPersonInfo(string name, int age)
        {
            bool isAdult = age >= 18;
            return (name, age, isAdult);
        }
    }
}
//?????????