using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {

        static int InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter the Number: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static int Calculate()
        {
            int num = InputNum, reverse = 0;
            while(num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;
            }
            return reverse;
        }

        public static void DisplayResult()
        {
            Console.WriteLine("The Reverse of the Number " + InputNum + " is: " + Calculate());
        }
    }
}
