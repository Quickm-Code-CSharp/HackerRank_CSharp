using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_GradeStudents : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_GradeStudents(string filename) : base(filename)
        {
            Grades = new List<int>();

            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_Math_GradeStudents grader = new Algorithm_Math_GradeStudents();

            Console.WriteLine("Algorithm: Math: Grade students: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine(" Scores: {0}", PrintList<int>(Grades));

            Console.WriteLine("Output:  ");
            var output = grader.gradingStudents(Grades);
            Console.WriteLine(" Grades: {0}", PrintList<int>(output));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            
            switch (index)
            {
                case 0:
                    Count = ConvertToInt(line);
                    break;
                default:
                    int grade = ConvertToInt(line);
                    Grades.Add(grade);
                    break;
            }
        }

        public int Count { get; protected set; }
        public List<int> Grades { get; protected set; }
    }
}
