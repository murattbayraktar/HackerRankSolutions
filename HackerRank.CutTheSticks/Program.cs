using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] result = cutTheSticks2(arr);
        }

        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            int[] result = new int[1000];
            int resultIterator = 0;

            while(arr.Where(x=> x != 0).Count() > 0)
            {
                int minimum = arr.Where(x=>x !=0).Min();
                resultIterator += 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] != 0 && arr[i] >= minimum)
                    {
                        result[resultIterator] += 1;
                        arr[i] = arr[i] - minimum;
                    }
                }
            }
            result = result.Where(x => x != 0).ToArray();
            return result;
        }

        // Complete the cutTheSticks function below.
        static int[] cutTheSticks2(int[] arr)
        {
            List<int> result = new List<int>();
            int resultIterator = 0;

            while (arr.Where(x => x != 0).Count() > 0)
            {
                int minimum = arr.Where(x => x != 0).Min();
                resultIterator += 1;
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0 && arr[i] >= minimum)
                    {
                        counter += 1;
                        arr[i] = arr[i] - minimum;
                    }
                }

                if (counter > 0)
                    result.Add(counter);
            }

            return result.ToArray();
        }
    }
}
