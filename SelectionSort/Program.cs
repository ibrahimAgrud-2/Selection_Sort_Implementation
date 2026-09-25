using System;
using System.Dynamic;

namespace SelectionSort
{
    class Program
    {


        public static void ComputeSelectionSort(int[] array)
        {
            int minElement;
            int indexOfMinElement=0;

            for (int i = 0; i < array.Length; i++)
            {
                
                //in this loop, we find the min element of array. Her bir aşama için yani her bir subarray için min value bulmalıyız
                minElement=array[i];
                for (int k = i; k < array.Length; k++)
                {
                    if (array[k] < minElement)
                    {
                        minElement=array[k];
                      
                    }
                    
                }   
               indexOfMinElement=array.IndexOf(minElement);
               //eğer min eleman zaten en sonda ise swaplık bir durum yok
                if(indexOfMinElement==i)
                {
                    break;
                }
               //Swap
               ( array[i], array[indexOfMinElement])=(array[indexOfMinElement],array[i]);
            }
        }



        public static void Main()
        {Console.Clear(); //alt T enter //Not al


            int[] array = { 6,5,4,9,2,1};

            //algoritma tamam gibi sadece extreme durumlar için test edilebilir
            ComputeSelectionSort(array);
            
            foreach (var item in array)
            {
                System.Console.Write(item+" ");
            }
        
        }

    }
}