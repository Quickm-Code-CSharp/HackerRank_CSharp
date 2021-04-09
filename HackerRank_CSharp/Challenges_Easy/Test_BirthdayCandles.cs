using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_BirthdayCandles : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_BirthdayCandles(string filename) : base(filename)
        {
            Data = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Sort_BirthdayCandles candles = new Algorithm_Sort_BirthdayCandles();

            Console.WriteLine("Algorithm: Sort: Birthday candles: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" Candles: {0}", PrintList<int>(Data));

            Console.WriteLine("Output:  ");
            Console.WriteLine(" {0}", candles.BirthdayCakeCandles(Data));
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

        public int          Count   { get; protected set; }
        public List<int>    Data    { get; protected set; }
    }
}
