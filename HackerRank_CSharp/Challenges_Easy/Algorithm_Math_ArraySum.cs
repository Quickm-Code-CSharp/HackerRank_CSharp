using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_ArraySum
    {
        public int SimpleArraySum(List<int> data)
        {

            /*
             * Write your code here.
             */
            // Use Linq
            int sum = data.ToArray().Sum();

            return sum;

        }
    }
}
