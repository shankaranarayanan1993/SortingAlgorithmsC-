using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortAlgos
{
   public class MergeSort
    {
        public int [] MergeSortArr(int [] numbers)
        {
            // Check if the numbers length is greater that 2,if not return the number

            int length = numbers.Length;
            if(numbers.Length <2)
            {
                return numbers;
            }
            List <int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0;i< length; i++)
            {
                if (i % 2 == 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }
            left = MergeSortArr(left.ToArray()).ToList();
            right= MergeSortArr(right.ToArray()).ToList();
            return Merge(left, right).ToArray();
        }
        public List <int>  Merge(List <int> left, List <int> right)
        {
            List<int> resultArr = new List<int>();
            while(left.Count > 0 && right.Count > 0)
            {
                if(left.First()< right.First())
                {
                    resultArr.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    resultArr.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            while(left.Count > 0)
            {
                resultArr.Add(left.First());
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                resultArr.Add(right.First());
                right.RemoveAt(0);
            }
            return resultArr;
        }
    }
}
