using HackerRank_CSharp.Properties;
using System;
using System.Resources;

namespace HackerRank_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String testfile;

            testfile = TestResources.ResourceManager.GetString("Day7_ArrayResource");

            Test_Day7_Array_Reverse test = new Test_Day7_Array_Reverse(testfile);

            test.test();
        }
    }
}
