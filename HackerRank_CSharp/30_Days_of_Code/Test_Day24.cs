using HackerRank_CSharp.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day24 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day24(string filename) : base(filename)
        {
            Data = new List<int>();
            Head = null;

            ProcessData(Lines);
        }

        public void Test()
        {
            Day24_LinkedList_RemoveDuplicateNode tree = new Day24_LinkedList_RemoveDuplicateNode();

            InsertData();

            Console.WriteLine("Day 24: Linked List: Remove Redundant Nodes: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("{0}", PrintList<int>(Data));
            Console.WriteLine("Output:  ");
            Head = tree.RemoveDuplicateNodes(Head);
            Console.WriteLine("{0}", PrintLinkedList(Head));
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

        protected void InsertData()
        {
            Head = new Node_LinkedList(Data[0]);
            Node_LinkedList node = Head;
            for (int i = 1; i < Data.Count;i++)
            {
                node.Next = new Node_LinkedList(Data[i]);
                node = node.Next;
            }
        }




        public int              Count { get; protected set; }
        public List<int>        Data { get; protected set; }
        public Node_LinkedList  Head { get; protected set; }

    }
}
