using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_CompareTriplets : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_CompareTriplets(string filename) : base(filename)
        {
            A = new List<int>();
            B = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_String_CompareTriplets compare = new Algorithm_String_CompareTriplets();

            Console.WriteLine("Algorithm: String: Compare triplets: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" A: {0} B: {1}", PrintList<int>(A), PrintList<int>(B));

            Console.WriteLine("Output:  ");
            List<int> temp = compare.CompareTriplets(A, B);
            Console.WriteLine(" {0} {1}", temp[0], temp[1]);
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    A = ConvertToList(line);
                    break;
                case 1:
                    B = ConvertToList(line);
                    break;
                default:
                    break;
            }
        }

        public List<int> A { get; protected set; }
        public List<int> B { get; protected set; }
    }
}
