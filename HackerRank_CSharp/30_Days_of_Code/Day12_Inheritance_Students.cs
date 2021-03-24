using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Person
    {
		public Person(string aFirstName, string aLastName, int aIdentification) 
		{
			FirstName	= aFirstName;
			LastName	= aLastName;
			Id			= aIdentification;
		}
		protected string PrintPerson()
		{
			string result = String.Empty;
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("Name: {0}, {1}", LastName, FirstName);
			sb.AppendLine();
			sb.AppendFormat("ID: {0}", Id);

			result = sb.ToString();

			return result;
		}

        public override string ToString()
        {
            return PrintPerson();
        }

        public string FirstName { get; protected set; }
		public string LastName  { get; protected set; }
		public int    Id		{ get; protected set; }

	}
    class Day12_Inheritance_Students : Person
    {
        public Day12_Inheritance_Students(string aFirstName, string aLastName, int aIdentification, List<int> aTestScores) 
			: base(aFirstName, aLastName, aIdentification)
        {
			TestScores = new List<int>(aTestScores);
        }

		public char Calculate()
        {
            char grade = 'T';
            int sum = 0;
            foreach (int score in TestScores)
            {
                sum += score;
            }

            int avg = sum / TestScores.Count;

            if (avg >= 90 && avg <= 100) { grade = 'O'; }
            else if (avg >= 80 && avg < 90) { grade = 'E'; }
            else if (avg >= 70 && avg < 80) { grade = 'A'; }
            else if (avg >= 55 && avg < 70) { grade = 'P'; }
            else if (avg >= 40 && avg < 55) { grade = 'D'; }
            else if (avg < 40)              { grade = 'T'; }

            return grade;
        }

		public List<int> TestScores { get; protected set; }

	}
}
