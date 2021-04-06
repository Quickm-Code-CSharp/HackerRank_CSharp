using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day25 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day25(string filename) : base(filename)
        {
            Usecases = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Day25_Math_PrimeNumber prime = new Day25_Math_PrimeNumber();

            Console.WriteLine("Day 25: Math: Prime Number: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", prime.IsPrimeNumber(usecase));
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            int n;

            switch (index)
            {
                case 0:
                    n = ConvertToInt(line);
                    Count = n;
                    break;
                default:
                    n = ConvertToInt(line);
                    Usecases.Add(n);
                    break;
            }
        }

        public int          Count       { get; protected set; }
        public List<int>    Usecases    { get; protected set; }

    }
}
