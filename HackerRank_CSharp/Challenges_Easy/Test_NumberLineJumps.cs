using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Test_NumberLineJumps : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_NumberLineJumps(string filename) : base(filename)
        {
            Data     = new List<int>();
            Usecases = new List<List<int>>();
            ProcessData(Lines);
        }

        public void Test()
        {
            Algorithm_NumberLineJumps jumps = new Algorithm_NumberLineJumps();

            Console.WriteLine("Easy: Number Line Jumps: ");

            int x1;
            int v1;
            int x2;
            int v2;

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                x1 = usecase[0];
                v1 = usecase[1];
                x2 = usecase[2];
                v2 = usecase[3];

                Console.WriteLine("Usecase: x1: {0} v1: {1} x2: {2} v2: {3}", x1, v1, x2, v2);
                Console.WriteLine("Output:  {0}", jumps.Kangaroo(x1, v1, x2, v2));
                Console.WriteLine(" ");
            }
        }

        protected override void ProcessDataLine(string line, int index)
        {
            Data = ConvertToList(line);
            Usecases.Add(Data);
        }

        public List<int>        Data        { get; protected set; }
        public List<List<int>>  Usecases    { get; protected set; }

    }
}
