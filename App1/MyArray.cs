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
                        this.floatArray[j] = this.floatArray[j - gap];
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
        public void Selection_Sort_float()
        {
            int i;
            int smallIndex;
            int arrIndex;
            for (i = 0; i < this.floatArray.Length; i++)
            {
                smallIndex = i;
                for (arrIndex = i + 1; arrIndex < this.floatArray.Length; arrIndex++)
                {
                    if (this.floatArray[arrIndex] < this.floatArray[smallIndex])
                        smallIndex = arrIndex;
                }
                //Swap
                double temp = this.floatArray[i];
                this.floatArray[i] = this.floatArray[smallIndex];
                this.floatArray[smallIndex] = temp;
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
            int length = this.intArray.Length;
            int i = 0;
            int j = 0;
            for(i=1; i<length; ++i)
            {
                int temp = this.intArray[i];
                j = i - 1;
                while(j>=0 && this.intArray[j]>temp)
                {
                    this.intArray[j + 1] = this.intArray[j];
                    j = j - 1;
                }
                this.intArray[j + 1] = temp;
            }
            
        }
        public void Insertion_Sort_float()
        {
            int length = this.floatArray.Length;
            int i = 0;
            int j = 0;
            for (i = 1; i < length; ++i)
            {
                double temp = this.floatArray[i];
                j = i - 1;
                while (j >= 0 && this.floatArray[j] > temp)
                {
                    this.floatArray[j + 1] = this.floatArray[j];
                    j = j - 1;
                }
                this.floatArray[j + 1] = temp;
            }
        }

        public void MainMerge_int(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[20];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while((left<=eol)&&(mid<=right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for(i=0; i<num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }          
        }
        public void MainMerge_double(double[] numbers, int left, int mid, int right)
        {
            double[] temp = new Double[20];
            int i, pos;
            double eol, num;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        public void SortMerge_int(int[]numbers, int left, int right)
        {
            int mid;
            if(right>left)
            {
                mid = (right + left) / 2;
                SortMerge_int(numbers, left, mid);
                SortMerge_int(numbers, (mid + 1), right);
                MainMerge_int(numbers, left, mid + 1, right);
            }
        }
        public void SortMerge_double(double[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge_double(numbers, left, mid);
                SortMerge_double(numbers, (mid + 1), right);
                MainMerge_double(numbers, left, mid + 1, right);
            }
        }
        public void QuickSort_int(int[]arr, int start, int end)
        {
            int i; 
            if(start<end)
            {
                i = Partition(arr, start, end);
                QuickSort_int(arr, start, i - 1);
                QuickSort_int(arr, i + 1, end);
            }
        }
        public int Partition(int[]arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;
            for (int j=start; j<=end-1; j++)
            {
                if(arr[j]<=p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
        public void QuickSort_double(double[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition_double(arr, start, end);
                QuickSort_double(arr, start, i - 1);
                QuickSort_double(arr, i + 1, end);
            }
        }
        public int Partition_double(double[] arr, int start, int end)
        {
            double temp;
            double p = arr[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
    }
}
