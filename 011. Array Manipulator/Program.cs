using System;
using System.Linq;

namespace _011._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ');
                string commType = cmdArgs[0];
                if(commType== "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(index<0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers = ExchangeArray(numbers, index);
                }else if(commType=="min" || commType == "max")
                {
                    string oddOrEven = cmdArgs[1];
                    if (commType == "max")
                    {
                        int index = MaxElementIndex(numbers, oddOrEven);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(index);
                    }else if (commType == "min")
                    {
                        int index = MinElementIndex(numbers, oddOrEven);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(index);
                    }
                }else if (commType == "first" || commType=="last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string oddOrEven = cmdArgs[2];
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (commType == "first")
                    {
                        PrintFirstElementOfType(numbers, count, oddOrEven);
                    }else if (commType == "last")
                    {
                        PrintLastElementOfType(numbers, count, oddOrEven);
                    }

                }
            }
            Console.WriteLine(ArrayToStringFormat(numbers, numbers.Length));
        }
        static int[] ExchangeArray(int[] numbers, int index)
        {
            int[] exchangeNumbers = new int[numbers.Length];
            int currentIndex = 0;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangeNumbers[currentIndex] = numbers[i];
                currentIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                exchangeNumbers[currentIndex] = numbers[i];
                currentIndex++;
            }
            return exchangeNumbers;
        }
        static int MaxElementIndex(int[]numbers,string oddOrEven)
        {
            int index = -1;
            int maxValue = int.MinValue;
           for(int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (oddOrEven == "even")
                {

                   if(currNum%2==0 && currNum >= maxValue)
                   {
                        maxValue = currNum;
                        index = i;
                   }
                }else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && currNum >= maxValue)
                    {
                        maxValue = currNum;
                        index = i;
                    }
                }
           }
            return index;
        }
        static int MinElementIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int minValue = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (oddOrEven == "even")
                {

                    if (currNum % 2 == 0 && currNum <= minValue)
                    {
                        minValue = currNum;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && currNum <= minValue)
                    {
                        minValue = currNum;
                        index = i;
                    }
                }
            }
            return index;
        }
        static void PrintFirstElementOfType(int[]numbers,int count,string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstElementsIndex = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int curNumber = numbers[i];
                if (oddOrEven == "even")
                {
                    if(curNumber%2==0 && firstElementsIndex < count)
                    {
                        firstElements[firstElementsIndex] = numbers[i];
                        firstElementsIndex++;
                    }
                  
                }else if (oddOrEven == "odd")
                {
                    if (curNumber % 2 != 0 && firstElementsIndex < count)
                    {
                        firstElements[firstElementsIndex] = numbers[i];
                        firstElementsIndex++;
                    }
                }
            }
            Console.WriteLine(ArrayToStringFormat(firstElements, firstElementsIndex));
        }
        static void PrintLastElementOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastElementsIndex = 0;
            for (int i = numbers.Length-1; i >=0; i--)
            {
                int curNumber = numbers[i];
                if (oddOrEven == "even")
                {
                    if (curNumber % 2 == 0 && lastElementsIndex< count)
                    {
                        lastElements[lastElementsIndex] = numbers[i];
                        lastElementsIndex++;
                    }

                }
                else if (oddOrEven == "odd")
                {
                    if (curNumber % 2 != 0 && lastElementsIndex < count)
                    {
                        lastElements[lastElementsIndex] = numbers[i];
                        lastElementsIndex++;
                    }
                }
            }
            int[] reverseArray = new int[lastElementsIndex];
            int reversArrayIndex = 0;
            for(int i = lastElementsIndex - 1; i >= 0; i--)
            {
                reverseArray[reversArrayIndex] = lastElements[i];
                reversArrayIndex++;
            }
            Console.WriteLine(ArrayToStringFormat(reverseArray, reversArrayIndex)) ;
        }
        static string ArrayToStringFormat(int []array,int elementsCount)
        {
            string output = string.Empty;
            output += "[";
            for(int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output+=$"{array[i]}";
                }
                else
                {
                    output += $"{array[i]}, ";
                }
               
            }
            output += "]";
            return output;
        }
    }
   
}
