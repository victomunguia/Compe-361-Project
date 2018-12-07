using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class SortingAlgorithm
    {
        public SortingAlgorithm()
        {

        }

        private int[] Insertion_Sort(int[] userArray)
        {
            int i, j;
            for (i = 1; i <= userArray.Length; i++)
            {
                j = i;
                while ((j > 0) && (userArray[i] < userArray[j - 1]))
                {
                    userArray[j] = userArray[j - 1];
                    --j;
                }
                userArray[j] = userArray[i];
            }
            return userArray;
        }

        //Quick sort
        /*
         * Left index should be zero
         * Right is the lenght of the array minus one
         */
        private void Quick_Sort(int[] userArray, int leftIndex, int rightIndex)
        {
            int pivotIndex;
            if (leftIndex < rightIndex)
            {
                pivotIndex = PartitionQS(userArray, leftIndex, rightIndex);
                if (pivotIndex > 1)
                    Quick_Sort(userArray, leftIndex, pivotIndex - 1);
                if (pivotIndex + 1 < rightIndex)
                    Quick_Sort(userArray, pivotIndex + 1, rightIndex);
            }
        }
        //Helper for quick sort
        private int PartitionQS(int[] qsArray, int qsLeft, int qsRight)
        {
            int partPivot = qsArray[qsLeft];
            while (true)
            {
                while (qsArray[qsLeft] < partPivot)
                {
                    qsLeft++;
                }
                while (qsArray[qsRight] > partPivot)
                {
                    qsRight--;
                }
                if (qsLeft < qsRight)
                {
                    int temp = qsArray[qsRight];
                    qsArray[qsRight] = qsArray[qsLeft];
                    qsArray[qsLeft] = temp;
                }
                else
                {
                    return qsRight;
                }
            }
        }

        //Merge Sort
        private int[] Merge_Sort(int[] userArray)
        {
            if (userArray.Length <= 1)
                return userArray;

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < userArray.Length; i++)
            {
                if ((i % 2) > 0)
                {
                    left.Add(userArray[i]);
                }
                else
                {
                    right.Add(userArray[i]);
                }
            }

            left = Merge_Sort(left.ToArray()).ToList();
            right = Merge_Sort(right.ToArray()).ToList();

            return Merge(left, right);
        }
        private int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }
            return result.ToArray();
        }

        //Selection Sort (Kind of like Bubble sort)
        private void Selection_Sort(int[] userArray)
        {
            int i;
            int smallIndex;
            int arrIndex;
            for (i = 0; i < userArray.Length - 1; i++)
            {
                smallIndex = i;
                for (arrIndex = i + 1; arrIndex < userArray.Length; arrIndex++)
                {
                    if (userArray[arrIndex] < userArray[smallIndex])
                        smallIndex = arrIndex;
                }
                //Swap
                int temp = userArray[i];
                userArray[i] = userArray[smallIndex];
                userArray[smallIndex] = temp;
            }
        }

        //Shell Sort
        private void Shell_Sort(int[] userArray)
        {
            int arrSize = userArray.Length;
            int gap = arrSize / 2;
            int temp;
            int i;
            int j;

            while (gap > 0)
            {
                for (i = 0; i + gap < arrSize; i++)
                {
                    j = i + gap;
                    temp = userArray[j];

                    while (j - gap >= 0 && temp < userArray[j - gap])
                    {
                        userArray[j] = userArray[j - gap];
                        j = j - gap;
                    }
                    userArray[j] = temp;
                }
                gap = gap / 2;
            }
        }
    }
}
