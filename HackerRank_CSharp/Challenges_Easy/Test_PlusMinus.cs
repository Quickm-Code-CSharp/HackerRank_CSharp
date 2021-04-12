using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_PlusMinus : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_PlusMinus(string filename) : base(filename)
        {
            Data = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Math_PlusMinus    zero        = new Algorithm_Math_PlusMinus();
            double                      ratioPos;
            double                      ratioNeg;
            double                      ratioZero;

            Console.WriteLine("Algorithm: Math: PLus Minus: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("  {0}", PrintList<int>(Data));

            zero.plusMinus(Data, out ratioPos, out ratioNeg, out ratioZero);

            Console.WriteLine("Output:  ");
            Console.WriteLine(" Positive: {0}", ratioPos.ToString("F6"));
            Console.WriteLine(" Negative: {0}", ratioNeg.ToString("F6"));
            Console.WriteLine(" Zeroes  : {0}", ratioZero.ToString("F6"));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    Count = ConvertToInt(line);
                    break;
                default:
                    Data = ConvertToList(line);
                    break;
            }
        }

        public int          Count  { get; protected set; }
        public List<int>    Data   { get; protected set; }

    }
}
