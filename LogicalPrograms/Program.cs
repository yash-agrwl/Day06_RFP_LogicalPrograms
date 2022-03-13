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

            Console.WriteLine("\nProblem 2: Perfect Number");
            PerfectNumber.TakeInput();
            PerfectNumber.DisplayResult();

            Console.WriteLine("\nProblem 3: Prime Number");
            PrimeNumber.TakeInput();
            PrimeNumber.DisplayResult();

            Console.WriteLine("\nProblem 4: Reverse Number");
            ReverseNumber.TakeInput();
            ReverseNumber.DisplayResult();
        }
    }
}
