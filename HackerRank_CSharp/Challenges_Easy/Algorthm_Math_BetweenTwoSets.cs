using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorthm_Math_BetweenTwoSets
    {
        public int GetBetweenCount(List<int> factors, List<int> multiples)
        {
            int count = 0;

            factors.Sort();
            multiples.Sort();

            int num             = factors[^1];
            int factorLimit     = multiples[0];
            int factorSize      = factors.Count;
            int multipleSize    = multiples.Count;
            int multiplyFactor  = 2;

            // Check values in gap between highest value of factors and 
            // lowest value of multiples.
            while (num <= factorLimit)
            {
                bool isFactor = true;
                bool isMultiple = true;

                // Iterate through factors
                for (int i = 0; i < factorSize; ++i)
                {
                    if (num % factors[i] != 0)
                    {
                        isMultiple = false;
                        break;
                    }
                }

                // Iterate through multiples
                for (int j = 0; j < multipleSize; ++j)
                {
                    if (isMultiple && multiples[j] % num != 0)
                    {
                        isFactor = false;
                        break;
                    }
                }

                if (isMultiple && isFactor)
                {
                    count++;
                }
                // Update num value to next multiple
                num = factors[^1] * multiplyFactor;
                multiplyFactor++;
            }

            return count;
        }
    }
}
