using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int addResult = AddOperation(firstNumber, secondNumber);
            int finaleResult = SubstactionOperation(addResult, thirdNumber);
            Console.WriteLine(finaleResult);


        }
        static int AddOperation(int firstNumber,int secondNumber)
        {
            int addResult = firstNumber + secondNumber;
            return addResult;
        }
        static int SubstactionOperation(int addResult,int thirdNumber)
        {
            int subResult = addResult - thirdNumber;
            return subResult;
        }
    }
}
