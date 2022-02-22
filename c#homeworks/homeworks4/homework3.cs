using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class homework3
    {
        //int[] arr;
        public int[] arr { get; set; }
        public homework3(int size, int rangeStart, int step)
        {
            arr = new int[size];

            for(int i=0; i<size; i++)
            {
                if (i <= 1)
                    arr[i] += rangeStart;
                else
                    arr[i] += arr[i - 1] + step;
            }
        }

        public int Sum()
        {
            int result = 0;
            foreach (var item in arr) 
                result += item;
            return result;
        }

        public static void Inverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = -arr[i];
        }

        public static void Multi(int[] arr, int mult)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] * mult;
        }
        
        // maxcount не понял что требуется
    }
}
