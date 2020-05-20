using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int rowCount;
            int columnCount;

            string result = encryption(s);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static string encryption(string s)
        {
            int inputLength = s.Length;
            int rowCount;
            int columnCount;
            string resultString = string.Empty;

            double sqrtResult = Math.Sqrt(inputLength);
            if(sqrtResult % 1 == 0)
            {
                //sqrt result integer
                rowCount = columnCount = (int)sqrtResult;
            }
            else
            {
                //sqrt result float
                rowCount = (int)sqrtResult;
                columnCount = (int)sqrtResult + 1;
                checkMultipleControl(rowCount,columnCount, inputLength, out rowCount, out columnCount);
            }

            for (int i = 0; i < columnCount; i++)
            {
                int iterator = i;
                string rowString = "";
                for (int x = 0; x < columnCount; x++)
                {
                    rowString += s.Substring(iterator, 1);
                    iterator += columnCount;
                    if (iterator >= inputLength)
                        break;
                }
                resultString += rowString + " ";
            }

            return resultString;
        }

        private static void checkMultipleControl(int rowCount, int columnCount, int inputLength, out int newRowCount, out int newColumnCount)
        {
            if((rowCount * columnCount) >= inputLength)
            {
                newRowCount = rowCount;
                newColumnCount = columnCount;
            }
            else
            {
                newRowCount = rowCount + 1;
                newColumnCount = columnCount;
                checkMultipleControl(newRowCount, newColumnCount, inputLength, out newRowCount, out newColumnCount);
            }
        }
    }
}
