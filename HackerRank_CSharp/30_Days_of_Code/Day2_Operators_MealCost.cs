using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day2_Operators_MealCost
    {
        public int ComputeTotalMealCost(double meal_cost, int tip_percent, int tax_percent)
        {
            int     cost    = 0;
            double  tip     = tip_percent / 100.0;
            double  tax     = tax_percent / 100.0;

            double taxAmt = meal_cost * tax;
            double tipAmt = meal_cost * tip;

            cost = (int)Math.Round(meal_cost + taxAmt + tipAmt);

            return cost;
        }
    }
}
