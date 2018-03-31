﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class HeapSort
    {
        public static void Sort(ref int[] data)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int heapSize = data.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)                                           // cycling over the parent elements of the future heap;
            {
                MaxHeapify(ref data, heapSize, p);                                                  // Heapifying inputed array;

            }    
                

            for (int i = data.Length - 1; i > 0; --i)                                
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;

                --heapSize;
                MaxHeapify(ref data, heapSize, 0);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }

        private static void MaxHeapify(ref int[] data, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;                                        
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && data[left] > data[index])
                largest = left;                                                      
            else
            {
                largest = index;
            }

            if (right < heapSize && data[right] > data[largest])
                largest = right;

            if (largest != index)
            {                                                                             
                int temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                MaxHeapify(ref data, heapSize, largest);
            }
        }

        
    }
}
