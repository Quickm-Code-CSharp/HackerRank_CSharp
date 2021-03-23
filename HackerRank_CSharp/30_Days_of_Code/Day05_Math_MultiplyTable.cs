using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day05_Math_MultiplyTable
    {
        public string MakeMultiplyTable(int n)
        {
            string          result  = String.Empty;
            StringBuilder   sb      = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                // cout << n << " x " << i << " = " << n * i << endl;
                sb.AppendFormat("{0} x {1} = {2}", n, i, n * i);
                if (i < 9)
                {
                    sb.AppendLine();
                }
            }

            result = sb.ToString();

            return result;
        }
    }
}
