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
         public void Shell_Sort_int()
        {
            int arrSize = this.intArray.Length;
            int gap = arrSize / 2;
            int temp;
            int i;
            int j;

            while (gap > 0)
            {
                for (i = 0; i + gap < arrSize; i++)
                {
                    j = i + gap;
                    temp = this.intArray[j];

                    while (j - gap >= 0 && temp < this.intArray[j - gap])
                    {
                        this.intArray[j] = this.intArray[j - gap];
                        j = j - gap;
                    }
                    this.intArray[j] = temp;
                }
                gap = gap / 2;
               
            }
        }
        public void Shell_Sort_float()
        {
            int arrSize = this.floatArray.Length;
            int gap = arrSize / 2;
            double temp;
            int i;
            int j;

            while (gap > 0)
            {
                for (i = 0; i + gap < arrSize; i++)
                {
                    j = i + gap;
                    temp = this.floatArray[j];

                    while (j - gap >= 0 && temp < this.floatArray[j - gap])
                    {
                        this.intArray[j] = this.intArray[j - gap];
                        j = j - gap;
                    }
                    this.floatArray[j] = temp;
                }
                gap = gap / 2;

            }
        }
        //Selection Sort (Kind of like Bubble sort)
        public void Selection_Sort_int()
        {
            int i;
            int smallIndex;
            int arrIndex;
            for (i = 0; i < this.intArray.Length; i++)
            {
                smallIndex = i;
                for (arrIndex = i + 1; arrIndex < this.intArray.Length; arrIndex++)
                {
                    if (this.intArray[arrIndex] < this.intArray[smallIndex])
                        smallIndex = arrIndex;
                }
                //Swap
                int temp = this.intArray[i];
                this.intArray[i] = this.intArray[smallIndex];
                this.intArray[smallIndex] = temp;
            }
        }
        //Insertion sort
        /*
         * -In-place
         * -Simple implementation but less efficient then that of 
         *  the more advance sorting i.e. merge sort
         */
        public void Insertion_Sort_int()
        {
            int i, j;
            for (i = 1; i < this.intArray.Length; i++)
            {
                j = i;
                while ((j > 0) && (this.intArray[i] < this.intArray[j - 1]))
                {
                    this.intArray[j] = this.intArray[j - 1];
                    --j;
                }
                this.intArray[j] = this.intArray[i];
            }
        }

    }
}
