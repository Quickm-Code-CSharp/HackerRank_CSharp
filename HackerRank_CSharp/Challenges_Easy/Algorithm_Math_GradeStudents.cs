using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.Challenges_Easy
{
    class Algorithm_Math_GradeStudents
    {
        public List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            int finalGrade;

            foreach (int grade in grades)
            {
                int multiple = grade / 5;

                if (grade >= 38)
                {
                    finalGrade = ((multiple + 1) * 5 - grade < 3) ? (multiple + 1) * 5
                                                                  : grade;
                }

                else
                {
                    finalGrade = grade;
                }

                result.Add(finalGrade);
            }

            return result;
        }
    }
}
