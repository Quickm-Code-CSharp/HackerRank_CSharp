using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day8_Dictionary_Telephone
    {
        public string FindName(Dictionary<string, string> data, string name)
        {
            string result = "Not found";
            string number;

            if (data.TryGetValue(name, out number))
            {
                result = String.Format("{0}={1}", name, number);
            }

            return result;
        }
    }
}
