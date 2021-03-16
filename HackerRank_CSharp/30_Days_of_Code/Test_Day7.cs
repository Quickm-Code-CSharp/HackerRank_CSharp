using System;
using System.Collections.Generic;

namespace HackerRank_CSharp
{
    class Test_Day7 : Test_CodeChallenge
    {
        public Test_Day7(String filename)
        {
            ReadData(filename);
        }

        public void test()
        {
            List<int> data = Data;

            Day7_Array_Reverse reverse = new Day7_Array_Reverse();

            Console.WriteLine("Input:  {0}", printListInt(data));
            Console.WriteLine("Output: {0}", reverse.ReverseArray(data));
            Console.WriteLine(" ");
        }

        protected void ReadData(String filename)
        {
            String      line;
            int[]       nums;
            string[]    lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            for (int i = 0; i < lines.Length; i += 1)
            {
                line = lines[i];
                // Process line
                switch (i)
                {
                    case 0:
                        int n = int.Parse(line);
                        Count = n;
                        break;
                    default:
                        string[] strings    = line.Split(' ');
                        nums                = Array.ConvertAll(strings, s => int.Parse(s));
                        Data                = new List<int>(nums);
                        break;
                }
            }


        }

        public int          Count { get; protected set; }
        public List<int>    Data { get; protected set; }
    }
};
