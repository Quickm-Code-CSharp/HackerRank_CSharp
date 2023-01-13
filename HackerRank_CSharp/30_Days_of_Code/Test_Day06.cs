using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day06 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day06(string filename) : base(filename)
        {
            Data = new List<string>();
            ProcessData(Lines);
        }

        public void Test()
        {
            List<string> data = Data;

            Day06_String_EvenOdd evenOdd = new Day06_String_EvenOdd();

            Console.WriteLine("Day 06: String Even or Odd: ");
            Console.WriteLine("Input:  {0}", PrintList<string>(data));

            var output = evenOdd.EvenOddStrings(data);
            Console.WriteLine("Output: {0}", PrintList<string>(output));
            Console.WriteLine(" ");

        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    int n = ConvertToInt(line);
                    Count = n;
                    break;
                default:
                    Data.Add(line);
                    break;
            }
        }

        public int Count { get; protected set; }
        public List<string> Data { get; protected set; }

    }
}
