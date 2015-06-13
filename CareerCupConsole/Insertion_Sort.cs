using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
    class Insertion_Sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 15, 16, 12, 2, 5, 6 };

            insertion_sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(string.Format(" {0}", arr[i]));
            }
            Console.ReadKey();
        }

        private static void insertion_sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int key = arr[i];

                while (j > 0 && arr[j - 1] > key)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = key;

            }
        }
    }
}
