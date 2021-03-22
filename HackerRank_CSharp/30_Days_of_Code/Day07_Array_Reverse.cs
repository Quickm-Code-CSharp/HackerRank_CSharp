using System;
using System.Collections.Generic;

namespace HackerRank_CSharp
{
    class Day07_Array_Reverse
    {
        //Objective
        //Today, we will learn about the Array data structure.Check out the Tutorial tab for learning materials and an instructional video.
        //
        //Task
        //Given an array, , of integers, print 's elements in reverse order as a single line of space-separated numbers.
        //
        //Example
        //Print 4 3 2 1. Each integer is separated by one space.
        //
        //Input Format
        //The first line contains an integer, (the size of our array).
        //The second line contains  space-separated integers that describe array 's elements.
        //
        //Output Format
        //Print the elements of array  in reverse order as a single line of space-separated numbers.
        //
        //Sample Input
        //4
        //1 4 3 2
        //
        //Sample Output
        //2 3 4 1

        public String ReverseArray(List<int> arr)
        {
            String result = String.Empty;

            var nums = arr.ToArray();
            Array.Reverse(nums);

            foreach(var item in nums)
            {
                result += item.ToString();
                result += " ";
            }

            result = result.Trim();

            return result;

        }
    }
}
