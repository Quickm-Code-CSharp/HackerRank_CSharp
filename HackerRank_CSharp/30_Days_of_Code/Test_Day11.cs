using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day11 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day11(string filename) : base(filename)
        {
            Data     = new int[Dimension, Dimension];
            Usecases = new List<int[,]>();
            ProcessData(Lines);
        }


        public void Test()
        {
            Day11_Array_HourglassSum sum = new Day11_Array_HourglassSum();

            Console.WriteLine("Day 11: Array Hourglass Sum: ");

            Console.WriteLine("Test Usecases: ");
            foreach (var usecase in Usecases)
            {
                Console.WriteLine("Usecase: {0}", Print2DArray(usecase));
                Console.WriteLine("Output:  {0}", sum.FindMaxHourglassSum(usecase, Dimension));
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            // This processes only 1 usecase
            if (index == 0)
            {
                int num = ConvertToInt(line);
                Dimension = num;

                Data = new int[Dimension, Dimension];
            }

            else
            {
                string[]    strings = line.Split(' ');
                int         value;
                int row = (index - 1) % Dimension;

                for (int col = 0; col < Dimension; col++)
                {
                    value = int.Parse(strings[col]);
                    Data[row, col] = value;    
                }

                if (index % Dimension == 0)
                {
                    // Allocate new another 2D array to add to usecase list
                    // Copy data
                    // Add to Usecase list
                    // Clear Data array for next usecase data
                    int[,] usecase = new int[Dimension, Dimension];

                    Array.Copy(Data, usecase, Data.Length);
                    Usecases.Add(usecase);
                    Array.Clear(Data, 0, Data.Length);
                }
            }
        }


        public int          Dimension   { get; protected set; }
        public int[,]       Data        { get; protected set; }

        public List<int[,]> Usecases    { get; protected set; }

    }
}
