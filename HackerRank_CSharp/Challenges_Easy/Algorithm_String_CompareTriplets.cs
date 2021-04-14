using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_String_CompareTriplets
    {
        public List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>() { 0, 0 };

            for (int index = 0; index < 3; index++)
            {
                if (a[index] > b[index])
                {
                    result[0]++;
                }

                else if (a[index] < b[index])
                {
                    result[1]++;
                }
            }

            return result;
        }

    }
}
