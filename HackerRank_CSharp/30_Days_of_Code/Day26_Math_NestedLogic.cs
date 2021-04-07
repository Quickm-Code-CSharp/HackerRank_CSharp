using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day26_Math_NestedLogic
    {
        public int ComputeLibraryFine(LibraryDate dueDate, LibraryDate returnDate)
        {
            int fine = 0;

            // late year
            if (returnDate.year > dueDate.year)
            {
                fine = 10000;
            }

            // same year
            else if (returnDate.year == dueDate.year)
            {
                // late month
                if (returnDate.month > dueDate.month)
                {
                    int diff = returnDate.month - dueDate.month;

                    fine = 500 * diff;
                }

                // same month
                else
                {
                    if (returnDate.day > dueDate.day)
                    {
                        int diff = returnDate.day - dueDate.day;

                        fine = 15 * diff;
                    }
                }
            }

            return fine;
        }
    }
}
