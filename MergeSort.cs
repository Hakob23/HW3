using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort
    {


        public static void Sort(ref int[] arr, int bot, int top)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            

            if (bot == top)
            {
                return;                                                                 // base condition of recursion;
            }

            else
            {
                int mid = (bot + top) / 2;                                              // dividing the array into subarrays;
                                                                            
                Sort(ref arr, bot, mid);                                              // recursive call for the lower subarray;

                Sort(ref arr, mid+1, top);                                            // recursive call for the upper subarray;

                Merge(arr, bot, mid, top);                                        // merging 2 subarrays;
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }

        private static void Merge(int[] curArr, int low, int middle, int high)                  
        {

            int left = low;                                                                 
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];                                         // creating array with the length of 2 subarray's length's;
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))                                    // checking, if the pointers of 2 subarrays are still inside the arrays;
            {
                if (curArr[left] < curArr[right])                                          // if the  element in 1st subArr is smaller than in the element 2nd subArray; 
                {
                    tmp[tmpIndex] = curArr[left];                                          // the temporary array's current index is getting the value of that element;

                    left = left + 1;                                                       // moving to the right element and doing the same actions while the conditions are true  
                }

                else                                                                       // doing the same thing with the right subarray;
                {
                    tmp[tmpIndex] = curArr[right];                                           
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;                                                   // moving the ponter to 1 step right in the temporary array;
            }

            if (left <= middle)                                                            // checking, if there are still remaining elements in the left array after comparison;
            {
                while (left <= middle)
                {                                                                          // putting the values in the temporary array
                    tmp[tmpIndex] = curArr[left];                                           
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)                                                             // checking, if there are still remaining elements in the left array after comparison;
            {
                while (right <= high)
                {                                                                          // putting the values in the temporary array;
                    tmp[tmpIndex] = curArr[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)                                           // giving the values of the temporary array to the current array;
            {
                curArr[low + i] = tmp[i];
            }

        }


    }
}
