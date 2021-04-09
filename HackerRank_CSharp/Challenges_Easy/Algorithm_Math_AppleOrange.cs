using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_AppleOrange
    {
        public KeyValuePair<int, int> CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            KeyValuePair<int, int> results;

            int appleHit = 0;
            int orangeHit = 0;
            int d;

            foreach (int apple in apples)
            {
                d = a + apple;
                if (d >= s && d <= t)
                {
                    appleHit++;
                }
            }

            foreach (int orange in oranges)
            {
                d = b + orange;
                if (d >= s && d <= t)
                {
                    orangeHit++;
                }
            }

            results = new KeyValuePair<int, int>(appleHit, orangeHit);

            return results;
        }
    }
}
