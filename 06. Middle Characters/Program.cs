using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineText = Console.ReadLine();
            if (lineText.Length % 2 != 0)
            {
                Console.WriteLine(GetMiddleCharOdd(lineText));
            }
            else
            {
                GetMiddleCharEven(lineText);
            }
        }
        static char GetMiddleCharOdd(string lineText)
        {
            int halfLenght = lineText.Length / 2;
            char middle = lineText[halfLenght];
            return middle;
        }
        static void GetMiddleCharEven(string lineText)
        {
            int halfLenght = lineText.Length / 2;
            char firstChar = lineText[halfLenght-1];
            char secondChar = lineText[halfLenght];
            Console.WriteLine($"{firstChar}{secondChar}");
        }
    }
}
