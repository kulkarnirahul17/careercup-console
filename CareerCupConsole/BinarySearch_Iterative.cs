using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
    public class BinarySearch_Iterative
    {
        public static void Main()
        {
            int[] arr = new int[] { 10, 19, 35, 42, 56, 67, 99 };
            int key;

            Console.WriteLine("Enter a number to search: ");
            key = Convert.ToInt32(Console.ReadLine());

            if (binarySearch(arr, key, 0, arr.Length) == -1)
                Console.WriteLine("key not found");
            else
                Console.WriteLine("Key found: " + key);
            Console.ReadKey();
        }

        private static int binarySearch(int[] arr, int key, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return -1;

            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (key == arr[mid])
                    return key;

                if (key < arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
