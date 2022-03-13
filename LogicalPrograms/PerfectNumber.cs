using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {

        static int InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter the Number: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static bool Check()
        {
            int sum = 0;
            for (int i = 1; i <= InputNum/2; i++)
            {
                if (InputNum % i == 0)
                    sum += i;
            }
            if(sum == InputNum)
                return true;
            else
                return false;
        }

        public static void DisplayResult()
        {
            if (Check())
                Console.WriteLine("Entered Number, " + InputNum + " is a Perfect Number");
            else
                Console.WriteLine("Entered Number, " + InputNum + " is not a Perfect Number");
        }
    }
}
