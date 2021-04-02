using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp._30_Days_of_Code
{
    class Day20_Sort_BubbleSort
    {
        public int GetSwapCount(List<int> arr)
        {
            int count   = 0;
            int n       = arr.Count;

            for (int i = 0; i < n; i++)
            {
                 
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (arr[j] > arr[j + 1])
                    {
                        //swap(arr[j], arr[j + 1]);
                        swap(arr, j, j+1);
                        count++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (count == 0)
                {
                    break;
                }
            }


            return count;
        }

        protected void swap(List<int> arr, int index1, int index2)
        {
            int temp    = arr[index1]; // Copy the first position's element
            arr[index1] = arr[index2]; // Assign to the second element
            arr[index2] = temp; // Assign to the first element
        }
    }
}
