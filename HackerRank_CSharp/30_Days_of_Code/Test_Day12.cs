﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day12 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day12(string filename) : base(filename)
        {
            ProcessData(Lines);
        }

        public void Test()
        {
            Day12_Inheritance_Students students = new Day12_Inheritance_Students(FirstName, LastName, ID, TestScores);

            Console.WriteLine("Day 12: Inheriance Students: ");


            Console.WriteLine("Input:  ");
            Console.WriteLine("{0}", students.ToString());
            Console.WriteLine("Scores: {0}", PrintList<int>(TestScores));
            Console.WriteLine("Output:  ");
            Console.WriteLine("Grade: {0}", students.Calculate());
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    string[] strings = line.Split(' ');
                    FirstName = strings[0];
                    LastName  = strings[1];
                    int value = ConvertToInt(strings[2]);
                    ID = value;
                    break;
                case 1:
                    // skip
                    break;
                case 2:
                    TestScores = ConvertToList(line);
                    break;
                default:
                    break;
            }
        }

        public string       FirstName { get; protected set; }
        public string       LastName  { get; protected set; }
        public int          ID        { get; protected set; }
        public List<int>    TestScores{ get; protected set; }

    }
}
