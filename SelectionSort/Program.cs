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

                if (array[i] < minElement )
                {
                    minElement = array[i];
                }
      
            }

            return minElement;
        }


        

        public static void Main()
        {
                int [] array={1,2,3,4,5,6};

                int min=GetMinElementOfArray(array);

                System.Console.WriteLine(min);
        }

    }
}