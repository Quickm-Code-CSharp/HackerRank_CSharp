using System;
using System.Collections.Generic;

namespace HackerRank_CSharp
{
    class Day7_Array_Reverse
    {
        public String ReverseArray(List<int> arr)
        {
            String result = String.Empty;

            var nums = arr.ToArray();
            Array.Reverse(nums);

            foreach(var item in nums)
            {
                result += item.ToString();
                result += " ";
            }

            result = result.Trim();

            return result;

        }
    }
}
