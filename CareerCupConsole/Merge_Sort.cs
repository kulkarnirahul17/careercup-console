using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
	class Merge_Sort
	{
		public static void Main()
		{
			int[] arr = new int[] { 17, 8, 6 };

			mergeSort(arr, 0, arr.Length - 1);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i].ToString() + "   ");
			}
			Console.ReadKey();
		}

		private static void mergeSort(int[] arr, int start, int end)
		{
			if (start < end)
			{
				int mid = (start + end) / 2;
				mergeSort(arr, start, mid);
				mergeSort(arr, mid + 1, end);
				merge(arr, start, mid, end);
			}
		}

		private static void merge(int[] arr, int start, int mid, int end)
		{
			int i = 0;
			int j = 0;
			int k = start;

			int[] leftHalf = new int[mid - start + 1];
			int[] rightHalf = new int[end - mid];

			for (i = start; i <= mid; i++)
			{
				leftHalf[j++] = arr[i];
			}
			i = 0;
			for (j = mid + 1; j <= end; j++)
			{
				rightHalf[i++] = arr[j];
			}

			i = 0; j = 0;
			while (i < leftHalf.Length && j < rightHalf.Length)
			{
				if (leftHalf[i] < rightHalf[j])
					arr[k++] = leftHalf[i++];
				else
					arr[k++] = rightHalf[j++];
			}
			while (i < leftHalf.Length)
			{
				arr[k++] = leftHalf[i++];
			}
			while (j < rightHalf.Length)
				arr[k++] = rightHalf[j++];
		}
	}
}
