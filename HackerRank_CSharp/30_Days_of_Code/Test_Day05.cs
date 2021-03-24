using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day05 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day05(string filename) : base(filename)
        {
            Usecases = new List<int>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Day05_Math_MultiplyTable table = new Day05_Math_MultiplyTable();

            Console.WriteLine("Day 05: Math Multply Table: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", table.MakeMultiplyTable(usecase));
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            int value = ConvertToInt(line);
            Usecases.Add(value);
        }

        public List<int> Usecases { get; protected set; }

    }
}
