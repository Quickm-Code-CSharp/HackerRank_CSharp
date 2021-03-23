using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day09 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day09(string filename) : base(filename)
        {
            Usecases = new List<int>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Day09_Recursion_Factorial fact = new Day09_Recursion_Factorial();

            Console.WriteLine("Day 9: Recursion Factorial: ");
            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", fact.Factorial(usecase));
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
