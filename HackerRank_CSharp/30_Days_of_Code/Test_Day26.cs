using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    struct LibraryDate 
    {
        public LibraryDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            string output;

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}/{1}/{2}", month, day, year);

            output = sb.ToString();

            return output;
        }


        public int day   { get; set; }
        public int month { get; set; }
        public int year  { get; set; }

    }

    class Test_Day26 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day26(string filename) : base(filename)
        {
            ProcessData(Lines);
        }

        public void Test()
        {
            Day26_Math_NestedLogic library = new Day26_Math_NestedLogic();

            Console.WriteLine("Day 26: Math: Nested Logic: Library fines: ");

            Console.WriteLine("Input:  ");
            Console.WriteLine("Return Date: {0}", returnDate.ToString());
            Console.WriteLine("Due    Date: {0}", dueDate.ToString());
            Console.WriteLine("Output:  ");
            Console.WriteLine("{0}", library.ComputeLibraryFine(dueDate, returnDate));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            int day;
            int month;
            int year;
            string[] data;
            int[] array = null;

            switch (index)
            {
                case 0: // 
                    data = line.Split(' ');
                    array = Array.ConvertAll(data, s => int.Parse(s));

                    day   = array[0];
                    month = array[1];
                    year  = array[2];

                    returnDate = new LibraryDate(day, month, year);
                    break;
                case 1: // 
                    data = line.Split(' ');
                    array = Array.ConvertAll(data, s => int.Parse(s));

                    day   = array[0];
                    month = array[1];
                    year  = array[2];

                    dueDate = new LibraryDate(day, month, year);
                    break;
                default:
                    break;
            }
        }

        public LibraryDate dueDate      { get; protected set; }
        public LibraryDate returnDate   { get; protected set; }

    }
}
