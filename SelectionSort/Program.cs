using System;
using System.Dynamic;

namespace SelectionSort
{
    class Program
    {
        public static int GetMinElementOfArray(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int minElement = array[0];


            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < minElement)
                {
                    minElement = array[i];
                }

            }

            return minElement;
        }


        public static void ComputeSelectionSort(int[] array)
        {
            int minElement;
            int indexOfMinElement=0;

            for (int i = 0; i < array.Length; i++)
            {
                
                //in this loop, we find the min element of array.
                minElement=array[i];
                for (int k = i; k < array.Length; k++)
                {
                    if (array[k] < minElement)
                    {
                        minElement=array[k];
                      
                    }
                    
                }
               indexOfMinElement=array.IndexOf(minElement);
                if(indexOfMinElement==i)
                {
                    break;
                }
               //Swap
               ( array[i], array[indexOfMinElement])=(array[indexOfMinElement],array[i]);
            }
        }



        public static void Main()
        {Console.Clear();


            int[] array = { 6,5,4,9,2,1};

            ComputeSelectionSort(array);
            
            foreach (var item in array)
            {
                System.Console.Write(item+" ");
            }
        
        }

    }
}