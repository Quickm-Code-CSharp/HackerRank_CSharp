using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_PlusMinus
    {
        public void plusMinus(List<int> arr, out double ratioP, out double ratioM, out double ratioZ)
        {
            double countP = 0.0;
            double countM = 0.0;
            double countZ = 0.0;
            double length = arr.Count;

            foreach (var item in arr)
            {
                if (item > 0) { countP++; }
                else if (item < 0) { countM++; }
                else { countZ++; }
            }

            ratioP = countP / length;
            ratioM = countM / length;
            ratioZ = countZ / length;

            //cout.precision(6);
            //cout.setf(ios::fixed, ios::floatfield);
            //cout << countP / length << endl;
            //cout << countM / length << endl;
            //cout << countZ / length << endl;
        }
    }
}
