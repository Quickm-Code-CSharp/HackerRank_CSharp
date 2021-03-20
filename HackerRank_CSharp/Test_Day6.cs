using System;
using System.Collections.Generic;
using System.Text;
using HackerRank_CSharp._30_Days_of_Code;

namespace HackerRank_CSharp
{
    class Test_Day6 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day6(String filename)
        {
            Data = new List<string>();
            ReadData(filename);
        }

        public void Test()
        {
            List<string> data = Data;

            Day6_String_EvenOdd evenOdd = new Day6_String_EvenOdd();

            Console.WriteLine("Day 6: String Even or Odd: ");
            Console.WriteLine("Input:  {0}", PrintList(data));

            var output = evenOdd.EvenOddStrings(data);
            Console.WriteLine("Output: {0}", PrintList(output));
            Console.WriteLine(" ");

        }

        protected void ReadData(String filename)
        {
            string[]    lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            ProcessData(lines);

        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    int n = int.Parse(line);
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
