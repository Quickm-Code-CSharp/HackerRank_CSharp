using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_NumberLineJumps
    {
        public string Kangaroo(int x1, int v1, int x2, int v2)
        {
            string  result;
            bool    valid = false;

            if (v1 != v2)
            {
                valid = ((x1 - x2) % (v2 - v1)) == 0;
                valid = valid && (v1 > v2);
            }

            result = (valid) ? "YES" : "NO";

            return result;
        }

    }
}
