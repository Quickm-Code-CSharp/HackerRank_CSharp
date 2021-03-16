using System;
using System.Collections.Generic;
using System.Text;

using HackerRank_CSharp;

namespace HackerRank_CSharp
{
    class Test_Day7_Array_Reverse :  Test_CodeChallenge
    {

        public void test()
        {
            List<int> data = new List<int>() { 1, 4, 3, 2 };

            Day7_Array_Reverse reverse = new Day7_Array_Reverse();

            Console.WriteLine("Input:  {0}", printListInt(data));
            Console.WriteLine("Output: {0}", reverse.ReverseArray(data));
            Console.WriteLine(" ");
        }
    }
};
