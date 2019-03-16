using System;

namespace SortAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 3, 6, 7, 9, 56, 11, 222, 6, 8, 4, 5, 98 };

            //Console.WriteLine("=================Bubble Sort =====================================");
            //BubbleSort bbSort = new BubbleSort();
            //bbSort.bullleSort(unsortedArray);

            //Console.WriteLine("=================Selection Sort =====================================");
            //int[] unsortedArray1 = { 13, 2, 1 };
            //SelectionSort selectSort = new SelectionSort();
            //selectSort.selectionsSort(unsortedArray1);

            Console.WriteLine("=================MErge Sort =====================================");
            int[] unsortedArray2= { 13, 6, 7, 9, 56, 11, 222, 6, 8, 4, 5, 98 };
            MergeSort mergeSort = new MergeSort();
             int [] mergeSortArr=   mergeSort.MergeSortArr(unsortedArray2);
            Console.WriteLine("==================Sorted Array============================");
            foreach(int val in mergeSortArr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
