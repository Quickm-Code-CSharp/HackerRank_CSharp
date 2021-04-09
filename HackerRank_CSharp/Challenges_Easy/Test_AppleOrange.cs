using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_AppleOrange : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_AppleOrange(string filename) : base(filename)
        {
            Apples = new List<int>();
            Oranges = new List<int>();

            ProcessData(Lines);

        }

        public void Test()
        {
            Algorithm_Math_AppleOrange fruit = new Algorithm_Math_AppleOrange();

            Console.WriteLine("Algorithm: Math: Apples and Oranges: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" S: {0}  T: {1}", S, T);
            Console.WriteLine(" A: {0}  B: {1}", A, B);
            Console.WriteLine(" Apples:  {0}", PrintList<int>(Apples));
            Console.WriteLine(" Oranges: {0}", PrintList<int>(Oranges));
            Console.WriteLine("Output:  ");
            var output = fruit.CountApplesAndOranges(S, T, A, B, Apples, Oranges);
            Console.WriteLine(" Apple  count: {0}", output.Key);
            Console.WriteLine(" Orange count: {0}", output.Value);
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            List<int> temp;
            switch (index)
            {
                case 0:
                    temp = ConvertToList(line);
                    S = temp[0];
                    T = temp[1];
                    break;
                case 1:
                    temp = ConvertToList(line);
                    A = temp[0];
                    B = temp[1];
                    break;
                case 2:
                    // skip
                    break;
                case 3:
                    Apples = ConvertToList(line);
                    break;
                case 4:
                    Oranges = ConvertToList(line);
                    break;
                default:
                    break;
            }
        }

        public int          A       { get; protected set; }
        public int          B       { get; protected set; }
        public int          S       { get; protected set; }
        public int          T       { get; protected set; }
        public List<int>    Apples  { get; protected set; }
        public List<int>    Oranges { get; protected set; }
    }
}
