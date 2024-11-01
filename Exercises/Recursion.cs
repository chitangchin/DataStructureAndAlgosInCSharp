using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Recursion
    {
        public static int IterativeExponent(int num, int exponent)
        {
            int result = 1;
            int baseValue = num;

            //exponent = 2, num = 2
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                {
                    result *= baseValue;
                }

                //Square the base
                baseValue *= baseValue;

                //Divide the exponent by 2
                exponent /= 2;
            }
            return result;
        }
        public static int RecursiveExponent(int num, int exponent)
        {
            //base case
            if (exponent == 0)
            {
                return 1;
            }
            
            // 2 * 2 * 2 * 2 until exponent is 1
            return num * RecursiveExponent(num, exponent - 1);
        }
    }
}
