using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgos
{
    public class SelectionSort
    {
        public void selectionsSort(int [] unsortedArray)
        {
            Console.WriteLine("Unsorted Array");
            foreach (int val in unsortedArray)
            {
                Console.WriteLine(val);
            }
            // 2,3,4 5,88,7,44,5,6,7,8
            // Selection Sort works on Storing the value that is in  i index  in a Temp variable 
            // and compare that value with all the elements in the array using another loop with j
            int length = unsortedArray.Length;
            for (int i = 0; i < length-1; i++)
                // We loop throuh length -1 to make sure the index doesnot go beyond when we increment j = i+1;
            {
                int minValue = i;
                for(int j = i+1; j < length; j++)
                {
                    if (unsortedArray[j] < unsortedArray[minValue])
                    {
                        minValue = j;
                    }
                }
                int temp = unsortedArray[i];
                unsortedArray[i] = unsortedArray[minValue];
                unsortedArray[minValue] = temp;
            }
            Console.WriteLine("Sorted Array");
            foreach (int val in unsortedArray)
            {
                Console.WriteLine(val);
            }

        }

    }
}
