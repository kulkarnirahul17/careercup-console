using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
    public class BinarySearch_Recursive
    {
        public static void Main()
        {
            Console.WriteLine("Binary Search Recursive !!");

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
            if (low > high)
                return -1;

            int mid = (low + high) / 2;
            if (arr[mid] == key)
                return key;
            else if (key < arr[mid])
                return binarySearch(arr, key, low, mid - 1);
            else
                return binarySearch(arr, key, mid + 1, high);
        }
    }
}
