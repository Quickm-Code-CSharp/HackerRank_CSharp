using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day9_Recursion_Factorial
    {
        public ulong Factorial(int num)
        {
            ulong result = 0;

            if (num == 0)
            {
                result = 1;
            }

            else
            {
                result = (ulong)num * Factorial(num - 1);
            }

            return result;
        }
    }
}
