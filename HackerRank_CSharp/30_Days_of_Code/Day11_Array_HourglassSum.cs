using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day11_Array_HourglassSum
    {
        public int FindMaxHourglassSum(int [,] arr, int dimSize)
        {
            int maxSum  = 0;
            int sum     = 0;

            for (int row = 0; row < dimSize - 2; row++)
            {
                for (int col = 0; col < dimSize - 2; col++)
                {
                    sum += arr[row, col];
                    sum += arr[row, col + 1];
                    sum += arr[row, col + 2];
                    sum += arr[row + 1, col + 1];
                    sum += arr[row + 2, col];
                    sum += arr[row + 2, col + 1];
                    sum += arr[row + 2, col + 2];

                    if (row == 0 && col == 0)
                    {
                        maxSum = sum;
                    }
                    else if (sum > maxSum) { maxSum = sum; }
                    sum = 0;
                }
            }


            return maxSum;
        }

        protected int ComputeHourglassSum(int[,] arr, int row, int col)
        {
            int sum = 0;

            sum += arr[row, col];
            sum += arr[row, col + 1];
            sum += arr[row, col + 2];
            sum += arr[row + 1, col + 1];
            sum += arr[row + 2, col];
            sum += arr[row + 2, col + 1];
            sum += arr[row + 2, col + 2];

            return sum;
        }
    }
}
