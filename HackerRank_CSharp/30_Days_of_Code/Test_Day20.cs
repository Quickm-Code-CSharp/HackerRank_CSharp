using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day20 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day20(string filename) : base(filename)
        {
            Usecases = new List<List<int>>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Day20_Sort_BubbleSort sort = new Day20_Sort_BubbleSort();

            Console.WriteLine("Day 20: Sort: Bubble Sort Swap Count: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", PrintList<int>(usecase));
                Console.WriteLine("Output:  {0}", sort.GetSwapCount(usecase));
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            List<int> list = ConvertToList(line);
            Usecases.Add(list);
        }

        public List<List<int>>  Usecases    { get; protected set; }

    }
}
