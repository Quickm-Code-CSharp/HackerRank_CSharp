using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_ArraySum : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_ArraySum(string filename) : base(filename)
        {
            Data = new List<int>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Math_ArraySum sum = new Algorithm_Math_ArraySum();

            Console.WriteLine("Algorithm: Math: Array sum: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" Data: {0}", PrintList<int>(Data));

            Console.WriteLine("Output:  ");
            Console.WriteLine(" {0}", sum.SimpleArraySum(Data));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    Count = ConvertToInt(line);
                    break;
                case 1:
                    Data = ConvertToList(line);
                    break;
                default:
                    break;
            }
        }

        public int          Count   { get; protected set; }
        public List<int>    Data    { get; protected set; }
    }
}
