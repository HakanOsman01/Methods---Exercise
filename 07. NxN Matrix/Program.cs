﻿using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            printMatrix(number);
        }
        static void printMatrix(int number)
        {
            for(int row = 1; row <= number; row++)
            {
                for(int col = 1; col <= number; col++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
