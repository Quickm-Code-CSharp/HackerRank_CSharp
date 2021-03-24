using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_BetweenTwoSets : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_BetweenTwoSets(string filename) : base(filename)
        {
            Factors   = new List<int>();
            Multiples = new List<int>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Algorthm_Math_BetweenTwoSets between = new Algorthm_Math_BetweenTwoSets();

            Console.WriteLine("Easy: Between Two Sets: ");


            Console.WriteLine("Input:  ");
            Console.WriteLine("Factors: {0}", PrintList(Factors));
            Console.WriteLine("Multiples: {0}", PrintList(Multiples));
            Console.WriteLine("Output:  ");
            Console.WriteLine("Count: {0}", between.GetBetweenCount(Factors, Multiples));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    //skip
                    break;
                case 1:
                    Factors   = ConvertToList(line);
                    break;
                case 2:
                    Multiples = ConvertToList(line);
                    break;
                default:
                    break;
            }
        }

        public List<int> Factors   { get; protected set; }
        public List<int> Multiples { get; protected set; }
    }
}
