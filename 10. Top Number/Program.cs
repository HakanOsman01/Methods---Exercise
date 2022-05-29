using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            PrintNumbers(endNumber);
        }
        static void PrintNumbers(int endNumber)
        {
            for (int curNumber = 1; curNumber <= endNumber; curNumber++)
            {
                int curSum = SumOfDigiths(curNumber);
                if(CheckIsDivideEight(curSum) && CheckItHoldsOddDigith(curNumber))
                {
                    Console.WriteLine(curNumber);
                }
            }
        }
        static int SumOfDigiths(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigiht = number % 10;
                sum += currentDigiht;
                number /= 10;
            }
            return sum;
        }
        
        static bool CheckIsDivideEight(int sum)
        {
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool CheckItHoldsOddDigith(int number)
        {
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
