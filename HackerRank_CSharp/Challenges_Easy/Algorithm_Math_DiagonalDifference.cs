using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_DiagonalDifference
    {
        public int DiagonalDifference(int[,] arr)
        {
            // array is n x n where dimensions are equal
            int length = arr.GetLength(0);
            int sum_f = 0;
            int sum_b = 0;

            for (int index = 0; index < length; index++)
            {
                sum_f += arr[index, index];
                sum_b += arr[index, length - 1 - index];
            }

            int diff = Math.Abs(sum_f - sum_b);
            return diff;

        }

    }
}
