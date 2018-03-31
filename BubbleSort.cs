using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort
    {

        public  static int[] Sort(int[] a)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] sortedA = new int[a.Length];

            for (int i = 0; i<a.Length-1; i++)                   
            {
                sortedA[i] = a[i];

               for(int j = i+1; j<a.Length; j++)            
                {
                    if(a[i]> a[j])
                    {
                        int box = sortedA[i];

                        sortedA[i] = a[j];

                        sortedA[j] = box;
                    }
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
     
            return sortedA;

            
        }


    }
}
