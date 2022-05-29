using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsCount = CountingVowels(word);
            Console.WriteLine(vowelsCount);
            
        }
        static int CountingVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelsCount = 0;
            foreach(char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
