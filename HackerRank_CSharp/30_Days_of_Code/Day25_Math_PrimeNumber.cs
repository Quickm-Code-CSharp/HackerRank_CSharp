using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day25_Math_PrimeNumber
    {
        public bool IsPrimeNumber(int num)
        {
            bool isPrime = true;

            if      (num < 2)       { isPrime = false; }
            else if (num == 2)      { isPrime = true;  }
            else if (num % 2 == 0)  { isPrime = false; }
            else if (num > 2)
            {
                for (int i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
