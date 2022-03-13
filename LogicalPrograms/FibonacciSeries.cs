using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {

        static int Num1 = 0, Num2 = 1, InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter number of elements to print: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static void CalculateNext()
        {
            int next;
            for(int i = 3; i <= InputNum; i++)
            {
                next = Num1 + Num2;
                Console.Write(next + " ");
                Num1 = Num2;
                Num2 = next;
            }
        }

        public static void DisplayResult()
        {
            Console.Write(Num1 + " " + Num2 + " ");
            CalculateNext();
            Console.WriteLine();
        }
    }
}
