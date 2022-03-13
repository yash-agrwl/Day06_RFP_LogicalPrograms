using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {

        static int InputNum;

        public static void TakeInput()
        {
            Console.Write("Enter the Number: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
        }

        public static bool Check()
        {
            int count = 0;
            for (int i = 2; i <= InputNum / 2; i++)
            {
                if (InputNum % i == 0)
                    count++;
            }
            if (count == 0 && InputNum != 1 && InputNum != 0)
                return true;
            else
                return false;
        }

        public static void DisplayResult()
        {
            if (Check())
                Console.WriteLine("Entered Number, " + InputNum + " is a Prime Number");
            else
                Console.WriteLine("Entered Number, " + InputNum + " is not a Prime Number");
        }
    }
}
