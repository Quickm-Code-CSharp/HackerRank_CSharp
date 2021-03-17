using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day8 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day8(string filename)
        {
            Data        = new Dictionary<string, string>();
            Usecases    = new List<string>();

            ReadData(filename);
        }

        public void Test()
        {
            Day8_Dictionary_Telephone   finder  = new Day8_Dictionary_Telephone();
            Dictionary<string, string>  map     = Data;

            Console.WriteLine("Day 8: Dictionary Telephone: ");
            Console.WriteLine("Input:  {0}", PrintDictionary(map));

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", usecase);
                Console.WriteLine("Output:  {0}", finder.FindName(map, usecase));
            }

            Console.WriteLine(" ");
        }

        protected void ReadData(String filename)
        {
            String      line;
            string[]    lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            for (int i = 0; i < lines.Length; i += 1)
            {
                line = lines[i];
                // Process line

                if (i == 0)
                {
                    int n = int.Parse(line);
                    Count = n;
                }

                else if (i >= 1 && i <= Count)
                {
                    string[] strings = line.Split(' ');
                    Data.Add(strings[0], strings[1]);

                }

                else if (i > Count)
                {
                    Usecases.Add(line);
                }
            }
        }

        public int Count { get; protected set; }
        public Dictionary<string, string> Data { get; protected set; }
        public List<string> Usecases { get; protected set; }


    }
}
