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

        }

        private static void Test_30_Days()
        {
            const string parentKey = "30DaysOfCode";

            Test_SingleDay(parentKey, "Day2", "Test_Day02");
            Test_SingleDay(parentKey, "Day5", "Test_Day05");
            Test_SingleDay(parentKey, "Day6", "Test_Day06");
            Test_SingleDay(parentKey, "Day7", "Test_Day07");
            Test_SingleDay(parentKey, "Day8", "Test_Day08");
            Test_SingleDay(parentKey, "Day9", "Test_Day09");
            Test_SingleDay(parentKey, "Day10", "Test_Day10");
            Test_SingleDay(parentKey, "Day11", "Test_Day11");
            Test_SingleDay(parentKey, "Day12", "Test_Day12");
        }

        private static void Test_SingleDay(string parentKey, string dayKey, string testClass)
        {
            string          testfile;
            StringBuilder   sb          = new StringBuilder();

            // Get test data file
            testfile = GetTestFilePath(parentKey, dayKey);

            // Get type for test class
            sb.AppendFormat("{0}.{1}.{2}", "HackerRank_CSharp", "_30_Days_of_Code", testClass);
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
            path = Path.Combine(parentDir, path);

            return path;
        }
    }
}
