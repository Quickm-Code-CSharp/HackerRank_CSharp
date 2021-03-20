using HackerRank_CSharp._30_Days_of_Code;
using HackerRank_CSharp.Properties;
using System;
using System.IO;
using System.Resources;

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
            String parentDir;
            String testfile;

            parentDir = TestResources.ResourceManager.GetString("30DaysOfCode");

            testfile = TestResources.ResourceManager.GetString("Day2");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day2 day2 = new Test_Day2(testfile);
            day2.Test();


            testfile = TestResources.ResourceManager.GetString("Day6");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day6 day6 = new Test_Day6(testfile);
            day6.Test();


            testfile = TestResources.ResourceManager.GetString("Day7");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day7 day7 = new Test_Day7(testfile);
            day7.Test();

            testfile = TestResources.ResourceManager.GetString("Day8");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day8 day8 = new Test_Day8(testfile);
            day8.Test();

            testfile = TestResources.ResourceManager.GetString("Day9");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day9 day9 = new Test_Day9(testfile);
            day9.Test();

            testfile = TestResources.ResourceManager.GetString("Day10");
            testfile = Path.Combine(parentDir, testfile);

            Test_Day10 day10 = new Test_Day10(testfile);
            day10.Test();
        }
    }
}
