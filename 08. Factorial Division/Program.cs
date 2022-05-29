using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            BigInteger firstFactorial = CalculateFactorial(firstNumber);
            BigInteger secondFactorial = CalculateFactorial(secondNumber);
            double result = CalculateDivision(firstFactorial, secondFactorial);
            PrintResult(result);
        }
        static BigInteger CalculateFactorial(int number)
        {
            BigInteger fac = 1;
            for(int i = 1; i <= number; i++)
            {
                fac= fac *i;
            }
            return fac;
        }
        static double CalculateDivision(BigInteger firstFactorial,BigInteger secondFactorial)
        {
            double result = ((double)(firstFactorial / secondFactorial));
            return result;
        }
        static void PrintResult(double result)
        {
            Console.WriteLine($"{result:f2}");
        }
    }
}
