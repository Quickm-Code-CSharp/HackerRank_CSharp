using System;
using System.Collections.Generic;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day07 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day07(String filename) : base(filename)
        {
            ProcessData(Lines);
        }

        public void Test()
        {
            List<int> data = Data;

            Day07_Array_Reverse reverse = new Day07_Array_Reverse();

            Console.WriteLine("Day 7: Array Reverse: ");
            Console.WriteLine("Input:  {0}", PrintList(data));
            Console.WriteLine("Output: {0}", reverse.ReverseArray(data));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            int[] nums;

            switch (index)
            {
                case 0:
                    int n = int.Parse(line);
                    Count = n;
                    break;
                default:
                    string[] strings = line.Split(' ');
                    nums = Array.ConvertAll(strings, s => int.Parse(s));
                    Data = new List<int>(nums);
                    break;
            }
        }


        public int          Count { get; protected set; }
        public List<int>    Data { get; protected set; }
    }
};
