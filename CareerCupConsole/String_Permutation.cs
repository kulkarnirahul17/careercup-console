using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCupConsole
{
    public class String_Permutation
    {
        public static void Main()
        {
            char[] inputString = { 'A', 'B', 'C' };
            StringBuilder outputString = new StringBuilder();
            bool[] used = new bool[inputString.Length];

            permute(inputString, outputString, used, 0);
            Console.ReadKey();

        }

        private static void permute(char[] inputString, StringBuilder outputString, bool[] used, int level)
        {
            if (level == inputString.Length)
            {
                Console.Write(string.Format("\t{0}", outputString));

                return;
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                if (used[i])
                    continue;

                outputString.Append(inputString[i]);
                used[i] = true;

                permute(inputString, outputString, used, level + 1);
                used[i] = false;

                outputString.Length = outputString.Length - 1;
            }
        }
    }
}
