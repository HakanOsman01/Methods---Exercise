using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(first, second, third));
        }
        static int SmallestNumber(int fistNumber,int secondNumber,int thirdNumber)
        {
            int smallestNumber =Math.Min( Math.Min(fistNumber, secondNumber),thirdNumber);
            return smallestNumber;

        }
    }
}
