using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_DiagonalDifference : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_DiagonalDifference(string filename) : base(filename)
        {
            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Math_DiagonalDifference diff = new Algorithm_Math_DiagonalDifference();

            Console.WriteLine("Algorithm: Math: Diagonal difference: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" Matrix: {0}", Print2DArray<int>(Data));

            Console.WriteLine("Output:  ");
            Console.WriteLine(" {0}", diff.DiagonalDifference(Data));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            List<int> temp;

            switch (index)
            {
                case 0:
                    Count = ConvertToInt(line);
                    break;
                default:
                    if (Data == null)
                    {
                        Data = new int[Count, Count];
                    }
                    temp = ConvertToList(line);
                    for(int i = 0; i < temp.Count; i++)
                    {
                        Data[index - 1, i] = temp[i];
                    }
                    break;
            }
        }

        public int      Count   { get; protected set; }

        public int[,]   Data    { get; protected set; }
    }
}
