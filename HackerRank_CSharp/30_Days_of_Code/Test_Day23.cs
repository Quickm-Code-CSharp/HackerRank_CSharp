using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day23 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day23(string filename) : base(filename)
        {
            Data = new List<int>();
            Head = null;

            ProcessData(Lines);
        }

        public void Test()
        {
            Day23_Tree_LevelOrderTraversal tree = new Day23_Tree_LevelOrderTraversal();

            InsertData(tree);

            Console.WriteLine("Day 23: Binary Tree: Level Order Traversal: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("{0}", PrintList<int>(Data));
            Console.WriteLine("Output:  ");
            Console.WriteLine("{0}", tree.PrintLevelOrder(Head));
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

        protected void InsertData(BinaryTree tree)
        {
            foreach (int item in Data)
            {
                Head = tree.InsertTreeNode(Head, item);
            }
        }

        public int       Count { get; protected set; }
        public List<int> Data { get; protected set; }
        public Node_Tree Head { get; protected set; }

    }
}
