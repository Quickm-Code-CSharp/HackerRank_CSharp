using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day29_Bitwise_MaxAnd
    {
        public int BitwiseAnd(int N, int K)
        {
            int andValue;
            int maxValue = 0;
            for (int a = 1; a < N; a++)
            {
                for (int b = a + 1; b <= N; b++)
                {
                    andValue = a & b;
                    if (andValue < K && andValue > maxValue)
                    {
                        maxValue = andValue;
                    }
                }
            }

            return maxValue;
        }
    }
}
