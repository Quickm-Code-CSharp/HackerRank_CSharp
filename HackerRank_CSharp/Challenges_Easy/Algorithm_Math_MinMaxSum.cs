using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_MinMaxSum
    {
        public void MiniMaxSum(List<int> arr, out int minSum, out int maxSum)
        {
            int max = arr[0];
            int sum = 0;
            int min = arr[0];

            //foreach (var item in arr)
            //{
            //    sum += item;
            //}

            arr.ForEach(s => sum += s);

            arr.Sort();
            min = arr[0];
            max = arr[4];

            maxSum = sum - min;
            minSum = sum - max;
        }
    }
}
