using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day2 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day2(string filename)
        {
            ReadData(filename);
        }

        public void Test()
        {
            Day2_Operators_MealCost cost = new Day2_Operators_MealCost();

            Console.WriteLine("Day 2: Operators Meal Cost: ");
            Console.WriteLine("Input:  Meal: {0} Tip Percent: {1} Tax Percent: {2}", Meal_Cost,Tip_Percent, Tax_Percent);

            Console.WriteLine("Output: {0}", cost.ComputeTotalMealCost(Meal_Cost,Tip_Percent, Tax_Percent));
            Console.WriteLine(" ");
        }

        protected void ReadData(String filename)
        {
            string[] lines = { };

            if (!ReadInputFile(filename, ref lines))
            {
                System.Environment.Exit(-1);
            }

            ProcessData(lines);

        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    double n = double.Parse(line);
                    Meal_Cost = n;
                    break;
                case 1:
                    int tip = int.Parse(line);
                    Tip_Percent = tip;
                    break;
                case 2:
                    int tax = int.Parse(line);
                    Tax_Percent = tax;
                    break;
                default:
                    break;
            }
        }

        public double Meal_Cost { get; protected set; }
        public int    Tax_Percent { get; protected set; }
        public int    Tip_Percent { get; protected set; }


    }
}
