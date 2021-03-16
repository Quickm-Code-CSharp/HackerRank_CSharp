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

            Test_30_Days();

        }

        private static void Test_30_Days()
        {
            String testfile;
            String parentDir;

            testfile = TestResources.ResourceManager.GetString("Day7");
            parentDir = TestResources.ResourceManager.GetString("30DaysOfCode");

            testfile = Path.Combine(parentDir, testfile);

            Test_Day7 day7 = new Test_Day7(testfile);
            day7.test();
        }


    }
}
