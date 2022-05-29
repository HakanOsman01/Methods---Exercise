using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            while ((number = Console.ReadLine()) != "END")
            {
                string curBackNumber = GetBackNumber(number);
                bool isNumberPalindrome = CheckIsNumberIsPalindrome(number, curBackNumber);
                if (isNumberPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
        static bool CheckIsNumberIsPalindrome(string number,string backNumber)
        {
            if (number == backNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string GetBackNumber(string number)
        {
            string backNumber = string.Empty;
            for(int i = number.Length-1; i >= 0; i--)
            {
                backNumber += number[i];
            }
            return backNumber;
        }
    }
}
