using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp
{
    class Test_CodeChallenge
    {

        protected String printListInt(List<int> list, char delimiter = ' ')
        {
            String str = String.Empty;

            foreach(int item in list)
            {
                str += item.ToString();
                str += delimiter;
            }

            str = str.Trim(delimiter);

            return str;
        }
    }
}
