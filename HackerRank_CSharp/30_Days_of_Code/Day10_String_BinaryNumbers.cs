using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day10_String_BinaryNumbers
    {
        public int LongestBinaryCount(int decimalNumber)
        {
            int count = 0;
            string binaryStr;
            
            binaryStr = ConvertToBinary(decimalNumber);
            count = DetermineOneCount(binaryStr);

            return count;
        }

        protected string ConvertToBinary(int value)
        {
            string  binaryStr = String.Empty;
            int     remainder = 0;

            StringBuilder sb = new StringBuilder();

            // build binary string
            while (value > 0)
            {
                remainder = value % 2;
                value /= 2;
                sb = sb.Append(remainder);
            }
            binaryStr = sb.ToString();

            // reverse string
            char[] charArray = binaryStr.ToCharArray();
            Array.Reverse(charArray);
            binaryStr = new string(charArray);
            
            return binaryStr;
        }

        protected int DetermineOneCount(string binaryStr)
        {
            int     count       = 0;
            int     maxcount    = 0;
            int     length      = binaryStr.Length;
            char    prev        = ' ';
            char    curr;

            for (int i = 0; i < length; i++)
            {
                curr = binaryStr[i];

                if (i == 0 && curr == '1')
                {
                    count = 1;
                }

                if (curr == '1' && prev == '1')
                {
                    count++;
                }

                else if (prev == '1' && curr == '0')
                {
                    if (count > maxcount)
                    {
                        maxcount = count;
                    }
                    count = 0;
                }

                else if (prev == '0' && curr == '1')
                {
                    count++;
                }

                if (count > maxcount)
                {
                    maxcount = count;
                }

                prev = curr;
            }

            return maxcount;
        }
    }
}
