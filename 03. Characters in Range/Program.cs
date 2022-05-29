using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char fistLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char nextFirstLetter = (char)(fistLetter + 1);
            char nextSecondLetter = (char)(secondLetter + 1);
            if ((int)fistLetter > (int)secondLetter)
            {
                printLettersBetwen(nextSecondLetter, fistLetter);
            }
            else
            {
                printLettersBetwen(nextFirstLetter, secondLetter);
            }
            
        }
        static void printLettersBetwen(char firstLetter,char secondLetter)
        {
            for (char current = firstLetter; current <secondLetter; current++)
            {
                Console.Write($"{current} ");
            }
        }
    }
}
