using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_MinMaxSum : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_MinMaxSum(string filename) : base(filename)
        {
            Data = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Math_MinMaxSum sum = new Algorithm_Math_MinMaxSum();
            int minSum = 0;
            int maxSum = 0;
            Console.WriteLine("Algorithm: Math: MinMaxSum: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" Data: {0}", PrintList<int>(Data));

            Console.WriteLine("Output:  ");
            sum.MiniMaxSum(Data, out minSum, out maxSum);
            Console.WriteLine(" Min Sum:{0} Max Sum: {1}", minSum, maxSum);
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            Data = ConvertToList(line);
        }

        public List<int> Data { get; protected set; }
    }
}
