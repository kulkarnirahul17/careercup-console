using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
	public class StringCompression
	{
		public static void Main(string[] args)
		{
			int[,] mat = new int[6, 3];
			
			Console.WriteLine(string.Format("rows {0} columns {1}", mat.GetLength(0), mat.GetLength(1)));

			string str = "aabcccddddAAAA";
			string compressedStr = compress(str);
			Console.WriteLine(compressedStr);
			Console.ReadKey();
		}

		private static string compress(string str)
		{
			if (string.IsNullOrEmpty(str) || str.Length < 1)
				return str;

			int compressedLength = countCompression(str);
			if (compressedLength >= str.Length)
				return str;

			char[] arr = new char[compressedLength];
			int count = 1;
			int index = 0;
			char last = str[0];
			for (int i = 1; i < str.Length; i++)
			{
				if (str[i] == last)
				{
					count++;
				}
				else
				{
					setChar(arr, last, count, ref index);
					count = 1;
					last = str[i];
				}
			}
			setChar(arr, last, count, ref index);
			return new string(arr);
		}

		private static void setChar(char[] arr, char last, int count, ref int index)
		{
			arr[index++] = last;

			char[] countArr = count.ToString().ToCharArray();

			foreach (char c in countArr)
			{
				arr[index++] = c;
			}
		}

		private static int countCompression(string str)
		{
			if (str.Length == 1)
				return 2;

			int count = 1;
			int size = 0;

			char last = str[0];
			for (int i = 1; i < str.Length; i++)
			{
				if (str[i] == last)
				{
					count++;
				}
				else
				{
					size += count.ToString().ToCharArray().Length + 1;
					count = 1;
					last = str[i];
				}
			}
			size += count.ToString().ToCharArray().Length + 1;
			return size;
		}
	}
}
