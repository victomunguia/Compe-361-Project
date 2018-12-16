using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;

namespace App1 
{
    public class MyArray
    {
        //Boolean variable that will be utilized for selecting proper 
        //algorithm when establishing outputs
        public bool Quicksort = false;
        public bool MergeSort = false;
        public bool InsertionSort = false;
        public bool SelectionSort = false;
        public bool ShellSort = false;

        public bool Asceding = false;
        public bool Descending = false;
        public bool Random = false;

        public bool chooseFloat = false;
        public bool chooseInt = false;

        const int size = 20;
        public double[] floatArray = new double[size];
        public int[] intArray = new int[size];
    
        Random rand = new Random(100);
        
        public MyArray()
        {
            populateArray();


        }
        private void populateArray()
        {
        
                for (int index=0; index<size; index++)
                    floatArray[index] = rand.NextDouble()*5;
           
           
                for(int index=0; index<size; index++)
                    intArray[index] = rand.Next()%50;  
            
        }
        //Shell Sort
         void Shell_Sort(int[] userArray)
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
        //Selection Sort (Kind of like Bubble sort)
        private void Selection_Sort(int[] userArray)
        {
            int i;
            int smallIndex;
            int arrIndex;
            for (i = 0; i < userArray.Length - 1; i++)
            {
                smallIndex = i;
                for (arrIndex = i + 1; arrIndex < userArray.Length-1; arrIndex++)
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
        //Insertion sort
        /*
         * -In-place
         * -Simple implementation but less efficient then that of 
         *  the more advance sorting i.e. merge sort
         */
        private void Insertion_Sort(int[] userArray)
        {
            int i, j;
            for (i = 1; i <= userArray.Length-1; i++)
            {
                j = i;
                while ((j > 0) && (userArray[i] < userArray[j - 1]))
                {
                    userArray[j] = userArray[j - 1];
                    --j;
                }
                userArray[j] = userArray[i];
            }
        }

    }
}
