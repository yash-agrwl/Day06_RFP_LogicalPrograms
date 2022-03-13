using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Computation Of Logical Problems\n");

            Console.WriteLine("Problem 1: Fibonacci Series");
            FibonacciSeries.TakeInput();
            FibonacciSeries.DisplayResult();
        }
    }
}
