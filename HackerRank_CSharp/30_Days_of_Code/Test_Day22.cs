using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day22 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day22(string filename) : base(filename)
        {
            Data = new List<int>();
            Head = null;

            ProcessData(Lines);
        }

        public void Test()
        {
            Day22_Tree_Height tree = new Day22_Tree_Height();

            InsertData(tree);

            Console.WriteLine("Day 22: Binary Tree Height: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("{0}", PrintList(Data));
            Console.WriteLine("Output:  ");
            Console.WriteLine("{0}", tree.GetHeight(Head));
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
                    Data.Add(n);
                    break;
            }
        }

        protected void InsertData(Day22_Tree_Height tree)
        {
            foreach (int item in Data)
            {
                Head = tree.InsertTreeNode(Head, item);
            }
        }

        public Node_Tree Head { get; protected set; }
        public List<int> Data { get; protected set; }
        public int       Count { get; protected set; }
    }
}
