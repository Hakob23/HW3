using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Enter the Number");

            int c = Console.Read();

            int[] arr = new int[c];

            for (int i = 0; i < c; i++)
            {
                arr[i] = random.Next();
            }


            Console.WriteLine("Choose The Algorhitm ");

            Console.WriteLine("1: InsertSort");

            Console.WriteLine("2: BubbleSort");

            Console.WriteLine("3: Quick Sort");

            Console.WriteLine("4: Heap Sort");

            Console.WriteLine("5: Merge Sort");

            Console.WriteLine("6: All");

            

            string s = Console.ReadLine();

            if (s.Length > 1)
            {
                for (int i = Convert.ToInt32(s.Substring(0, 1)); i <= Convert.ToInt32(s.Substring(2, 3)); i++)
                {
                    switch (Convert.ToString(i))
                    {
                        case "1":
                            InsertSort.Sort(arr);
                            break;

                        case "2":
                            BubbleSort.Sort(arr);
                            break;

                        case "3":
                            QuickSort.Sort(arr, 0, arr.Length - 1);
                            break;

                        case "4":
                            HeapSort.Sort(ref arr);
                            break;

                        case "5":
                            MergeSort.Sort(ref arr, 0, arr.Length - 1);
                            break;

                    }
                }
            }
            else
            {
                switch (s)
                {
                    case "1":
                        InsertSort.Sort(arr);
                        break;

                    case "2":
                        BubbleSort.Sort(arr);
                        break;

                    case "3":
                        QuickSort.Sort(arr, 0, arr.Length - 1);
                        break;

                    case "4":
                        HeapSort.Sort(ref arr);
                        break;

                    case "5":
                        MergeSort.Sort(ref arr, 0, arr.Length - 1);
                        break;

                    case "6":
                        InsertSort.Sort(arr);
                        BubbleSort.Sort(arr);
                        QuickSort.Sort(arr, 0, arr.Length - 1);
                        HeapSort.Sort(ref arr);
                        MergeSort.Sort(ref arr, 0, arr.Length-1);
                        break;


                }

            }

            Console.ReadLine();
        }

        
    }


}
