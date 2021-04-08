using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day29 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day29(string filename) : base(filename)
        {
            Usecases = new Dictionary<int, int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Day29_Bitwise_MaxAnd max = new Day29_Bitwise_MaxAnd();

            Console.WriteLine("Day 29: Bitwise: Max and value: ");

            foreach (var item in Usecases)
            {
                int N = item.Key;
                int K = item.Value;

                Console.WriteLine("Input:  ");
                Console.WriteLine("  N = {0} K = {1}", N, K);
                Console.WriteLine("Output:  ");
                Console.WriteLine("  Maximum value: {0}", max.BitwiseAnd(N, K));
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            string[] fields;

            switch (index)
            {
                case 0:
                    Count = ConvertToInt(line);
                    break;

                default:
                            fields  = line.Split(' ');
                    int     key     = ConvertToInt(fields[0]);
                    int     value   = ConvertToInt(fields[1]);
                    Usecases.Add(key, value);
                    break;
            }
        }

        public int                  Count       { get; protected set; }
        public Dictionary<int, int> Usecases    { get; protected set; }
    }
}
