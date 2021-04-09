using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Sort_BirthdayCandles
    {
        public int BirthdayCakeCandles(List<int> candles)
        {
            int count = 0;
            int length = candles.Count;

            if (length == 1)
            {
                count = 1;
            }
            else if (candles.Count > 1)
            {
                candles.Sort();
                candles.Reverse();

                count = candles.Where(x => x.Equals(candles[0])).Count();
            }

            return count;
        }
    }
}
