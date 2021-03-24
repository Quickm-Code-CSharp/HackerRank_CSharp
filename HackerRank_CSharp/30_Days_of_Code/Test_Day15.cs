using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day15 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day15(string filename) : base(filename)
        {
            Data = new List<int>();
            Head = null;
            ProcessData(Lines);
        }

        public void Test()
        {
            Day15_LinkedList linkedList = new Day15_LinkedList();

            InsertData(linkedList);

            Console.WriteLine("Day 15: Linked List: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("{0}", PrintList(Data));
            Console.WriteLine("Output:  ");
            Console.WriteLine("{0}", linkedList.Display(Head));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    //skip
                    break;
                default:
                    int n = ConvertToInt(line);
                    Data.Add(n);
                    break;
            }
        }

        protected void InsertData(Day15_LinkedList list)
        {
            foreach (int item in Data)
            {
                Head = list.Insert(Head, item);
            }
        }

        public List<int> Data { get; protected set; }
        public Node      Head { get; protected set; }
    }
}
