using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day10 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day10(string filename) : base(filename)
        {
            Usecases = new List<int>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Day10_String_BinaryNumbers binary = new Day10_String_BinaryNumbers();

            Console.WriteLine("Day 10: String Binary Numbers: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", binary.LongestBinaryCount(usecase));
            }
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            int num = int.Parse(line);
            Usecases.Add(num);
        }


        public List<int> Usecases { get; protected set; }

    }
}
