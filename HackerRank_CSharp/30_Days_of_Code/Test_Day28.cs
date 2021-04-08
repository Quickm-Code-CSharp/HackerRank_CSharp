using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day28 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day28(string filename) : base(filename)
        {
            Data = new Dictionary<string, string>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Day28_String_EmailAddress email = new Day28_String_EmailAddress();

            Console.WriteLine("Day 28: String: Email address matching: ");

            Console.WriteLine("Input:  ");
            foreach(var item in Data)
            {
                Console.WriteLine("  {0} {1}", item.Value, item.Key);
            }

            Console.WriteLine("Output:  ");
            var output = email.CompileEmailList(Data, "gmail.com");
            Console.WriteLine("{0}", PrintList<string>(output,'\n'));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            string[] fields;
            string key;
            string value;

            switch (index)
            {
                case 0:
                    ConvertToInt(line);
                    break;
                default:
                    fields = line.Split(' ');
                    key = fields[1];
                    value = fields[0];
                    Data.Add(key, value);
                    break;
            }
        }

        public int Count { get; protected set; }
        public Dictionary<string, string> Data { get; protected set; }
    }
}
