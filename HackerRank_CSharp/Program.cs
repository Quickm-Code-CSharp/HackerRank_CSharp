using HackerRank_CSharp._30_Days_of_Code;
using HackerRank_CSharp.Properties;
using System;
using System.IO;
using System.Resources;
using System.Text;

namespace HackerRank_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HackerRank code challenges!");
            Console.WriteLine(" ");

            Test_30_Days();
            Test_Easy_Challenges();
        }

        private static void Test_30_Days()
        {
            const string parentKey    = "30DaysOfCode";
            const string namespaceKey = "_30_Days_of_Code";

            Console.WriteLine("30 Days of Coding Challenges:");

            Test_SingleDay(parentKey, namespaceKey ,"Day2", "Test_Day02");
            Test_SingleDay(parentKey, namespaceKey, "Day5", "Test_Day05");
            Test_SingleDay(parentKey, namespaceKey, "Day6", "Test_Day06");
            Test_SingleDay(parentKey, namespaceKey, "Day7", "Test_Day07");
            Test_SingleDay(parentKey, namespaceKey, "Day8", "Test_Day08");
            Test_SingleDay(parentKey, namespaceKey, "Day9", "Test_Day09");
            Test_SingleDay(parentKey, namespaceKey, "Day10", "Test_Day10");
            Test_SingleDay(parentKey, namespaceKey, "Day11", "Test_Day11");
            Test_SingleDay(parentKey, namespaceKey, "Day12", "Test_Day12");
            Test_SingleDay(parentKey, namespaceKey, "Day15", "Test_Day15");
            Test_SingleDay(parentKey, namespaceKey, "Day18", "Test_Day18");
            Test_SingleDay(parentKey, namespaceKey, "Day20", "Test_Day20");
            Test_SingleDay(parentKey, namespaceKey, "Day22", "Test_Day22");
            Test_SingleDay(parentKey, namespaceKey, "Day23", "Test_Day23");
            Test_SingleDay(parentKey, namespaceKey, "Day24", "Test_Day24");
            Test_SingleDay(parentKey, namespaceKey, "Day25", "Test_Day25");
            Test_SingleDay(parentKey, namespaceKey, "Day26", "Test_Day26");
            Test_SingleDay(parentKey, namespaceKey, "Day28", "Test_Day28");
            Test_SingleDay(parentKey, namespaceKey, "Day29", "Test_Day29");
        }

        private static void Test_Easy_Challenges()
        {
            const string parentKey      = "Challenges_Easy";
            const string namespaceKey   = "Challenges_Easy";

            Console.WriteLine("Easy Challenges:");

            Test_SingleDay(parentKey, namespaceKey, "BetweenTwoSets",  "Test_BetweenTwoSets");
            Test_SingleDay(parentKey, namespaceKey, "NumberLineJumps", "Test_NumberLineJumps");
            Test_SingleDay(parentKey, namespaceKey, "AppleOrange",     "Test_AppleOrange");
            Test_SingleDay(parentKey, namespaceKey, "GradeStudents",   "Test_GradeStudents");
            Test_SingleDay(parentKey, namespaceKey, "BirthdayCandles", "Test_BirthdayCandles");
            Test_SingleDay(parentKey, namespaceKey, "MinMaxSum",       "Test_MinMaxSum");
            Test_SingleDay(parentKey, namespaceKey, "PlusMinus",       "Test_PlusMinus");
        }

        private static void Test_SingleDay(string parentKey, string namespaceKey, string dayKey, string testClass)
        {
            string          testfile;
            StringBuilder   sb          = new StringBuilder();

            // Get test data file
            testfile = GetTestFilePath(parentKey, dayKey);

            // Get type for test class
            sb.AppendFormat("{0}.{1}.{2}", "HackerRank_CSharp", namespaceKey, testClass);
            testClass = sb.ToString();
            Type t = Type.GetType(testClass);

            // Instantiate and run test
            ICodeChallengeTest day = (ICodeChallengeTest)Activator.CreateInstance(t, testfile);
            day.Test();
        }

        private static string GetTestFilePath(string parent, string day)
        {
            string path;
            string parentDir;

            parentDir = TestResources.ResourceManager.GetString(parent);
            path = TestResources.ResourceManager.GetString(day);

            if (String.IsNullOrEmpty(parentDir) || String.IsNullOrEmpty(path))
            {
                Console.WriteLine("Error: Invalid Resource Retrieval. Parent: {0} Day: {1}", parent, day);
                System.Environment.Exit(-1);
            }

            path = Path.Combine(parentDir, path);

            return path;
        }
    }
}
