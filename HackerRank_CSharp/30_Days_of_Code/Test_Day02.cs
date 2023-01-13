using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Test_Day02 : Test_CodeChallenge, ICodeChallengeTest
    {
        public Test_Day02(string filename) : base(filename)
        {
            ProcessData(Lines);
        }

        public void Test()
        {
            Day02_Operators_MealCost cost = new Day02_Operators_MealCost();

            Console.WriteLine("Day 02: Operators Meal Cost: ");
            Console.WriteLine("Input:  Meal: {0} Tip Percent: {1} Tax Percent: {2}", Meal_Cost,Tip_Percent, Tax_Percent);

            Console.WriteLine("Output: {0}", cost.ComputeTotalMealCost(Meal_Cost,Tip_Percent, Tax_Percent));
            Console.WriteLine(" ");
        }

        protected override void ProcessDataLine(string line, int index)
        {
            switch (index)
            {
                case 0:
                    double n = ConvertToDouble(line);
                    Meal_Cost = n;
                    break;
                case 1:
                    int tip = ConvertToInt(line);
                    Tip_Percent = tip;
                    break;
                case 2:
                    int tax = ConvertToInt(line);
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
