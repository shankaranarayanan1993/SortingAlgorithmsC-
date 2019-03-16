using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgos
{
   public class BubbleSort
    {

        public void bullleSort(int [] unsortedArray)
        {
            Console.WriteLine("Unsorted Array");
            foreach(int val in unsortedArray)
            {
                Console.WriteLine(val);
            }
            long length = unsortedArray.Length;
            for (int i=0; i< length; i++)
            {
                for(int j = 0; j<length-1; j++)
                {
                    if(unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array");
            foreach (int val in unsortedArray)
            {
                Console.WriteLine(val);
            }
        }

    }
}
