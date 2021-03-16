using System;
using System.Collections.Generic;
using System.Text;


namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day6_String_EvenOdd
    {
        public List<string> EvenOddStrings(List<string> strArr)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();

            foreach (string temp in strArr)
            {
                string oddStr = String.Empty;
                string evenStr = String.Empty;
                //string output = String.Empty;

                for (int index = 0; index < temp.Length; index++)
                {
                    if (index % 2 == 0)
                    {
                        evenStr += temp[index];
                    }

                    else
                    {
                        oddStr += temp[index];
                    }
                }

                //output += evenStr + " " + oddStr;
                list.Add(new string(evenStr + " " + oddStr));
            }

            return list;
        }
    }
}
