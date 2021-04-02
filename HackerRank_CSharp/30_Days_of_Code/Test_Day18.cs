using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day18 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day18(string filename) : base(filename)
        {
            Usecases = new List<string>();
            ProcessData(Lines);

        }

        public void Test()
        {
            Day18_QueueStack qs = new Day18_QueueStack();

            Console.WriteLine("Day 18: Queues and Stacks: Palidrome: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                qs.LoadData(usecase);
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", qs.IsPalidrome());
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            Usecases.Add(line);
        }

        public List<string> Usecases { get; protected set; }

    }
}
