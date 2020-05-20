using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int singleRowCount = arr.Count();
            int sumLeftToRight = 0;
            int sumRightToLeft = 0;
            int result = 0;

            if (singleRowCount <= 0)
                return 0;

            for (int i = 0; i < singleRowCount; i++)
            {
                sumLeftToRight += arr[i][i];
                sumRightToLeft += arr[i][singleRowCount - (i+1)];
            }

            result = Math.Abs(sumLeftToRight - sumRightToLeft);

            return result;
        }
    }
}
