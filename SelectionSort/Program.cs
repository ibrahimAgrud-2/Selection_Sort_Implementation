using System;
using System.Dynamic;

namespace SelectionSort
{
    class Program
    {


        public static void ComputeSelectionSortDesc(int[] array)
        {
 
            int indexOfMinElement=0;

            for (int i = 0; i < array.Length; i++)
            {
                
                //in this loop, we find the min element of array. Her bir aşama için yani her bir subarray için min value bulmalıyız
                indexOfMinElement=i;
                for (int k = i; k < array.Length; k++)
                {
                    if (array[k]> array[indexOfMinElement])
                    {
                        indexOfMinElement=k;
                      
                    }
                    
                }   
                if(indexOfMinElement==i)
                {
                    break;
                }
               //Swap
               ( array[i], array[indexOfMinElement])=(array[indexOfMinElement],array[i]);
            }
        }

public static void ComputeSelectionSortAsc(int[] array)
        {
 
            int indexOfMinElement=0;

            for (int i = 0; i < array.Length; i++)
            {
                
                //in this loop, we find the min element of array. Her bir aşama için yani her bir subarray için min value bulmalıyız
                indexOfMinElement=i;
                for (int k = i; k < array.Length; k++)
                {
                    if (array[k]< array[indexOfMinElement])
                    {
                        indexOfMinElement=k;
                      
                    }
                    
                }   
                if(indexOfMinElement==i)
                {
                    break;
                }
               //Swap
               ( array[i], array[indexOfMinElement])=(array[indexOfMinElement],array[i]);
            }
        }
    static void SelectionSortAsc(int[] arr)
    {
        int n = arr.Length;

        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIndex])
                    minIndex = j;

            // Swap the found minimum element with the first element
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

        public static void Main()
        {Console.Clear(); //alt T enter //Not al


            int[] array = { 6,5,4,9,2,1};

            //algoritma tamam gibi sadece extreme durumlar için test edilebilir 
            ComputeSelectionSortDesc(array);
            
            foreach (var item in array)
            {
                System.Console.Write(item+" ");
            }
        
        }

    }
}