using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day9 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day9(string filename)
        {
            Usecases = new List<int>();
            ReadData(filename);
        }

        public void Test()
        {
            Day9_Recursion_Factorial fact = new Day9_Recursion_Factorial();
            List<int> usecases = Usecases;

            Console.WriteLine("Day 8: Dictionary Telephone: ");
            Console.WriteLine("Input:  {0}", PrintList(usecases));

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", fact.Factorial(usecase));
            }


        }

        protected void ReadData(String filename)
        {
            String line;
            string[] lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            int num;
            for (int i = 0; i < lines.Length; i += 1)
            {
                line = lines[i];
                // Process line

                num = int.Parse(line);
                Usecases.Add(num);
            }

        }

        public List<int> Usecases { get; protected set; }
    }
}
