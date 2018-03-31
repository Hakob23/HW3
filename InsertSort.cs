using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertSort
    {
        public static int[] Sort(int[] arr) 
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int [] sortedArr = new int[arr.Length];

            for(int i = 1; i< arr.Length; i++)
            {
                sortedArr[i - 1] = arr[i - 1];                 // gives the previous value to the Sorted Array;

                if(arr[i]< sortedArr[i-1])                     // checks if the current value is smaller than previous in the sorted array;
                {
                    for(int j = i-1; j >=0; j--)               // if it is, all the numbers in the sorted array moving right until,   
                    {
                        if (arr[i] < sortedArr[j])             // the current value of initial array will be bigger than the current value of sorted Array;
                        {
                            sortedArr[j + 1] = sortedArr[j];
                        }
                        else                                   // in that case the program will give current value of initial array to that current postion in the sorted array;
                        {
                            sortedArr[j + 1] = arr[i];         

                            break;
                        }
                     
                    }
                    
                }
            }

            watch.Stop();
             var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs);

            return  sortedArr;
        }
    }
}
