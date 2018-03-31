using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (left < right)
            {
                int mean = Partition(arr, left, right);

                if (mean > 1)
                {
                    Sort(arr, left, mean - 1);
                }
                if (mean + 1 < right)
                {
                    Sort(arr, mean + 1, right);
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs);

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int box = arr[left];
                    arr[left] = arr[right];
                    arr[right] = box;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
