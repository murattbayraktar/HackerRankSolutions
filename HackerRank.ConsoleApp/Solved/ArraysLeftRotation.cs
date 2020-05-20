using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ConsoleApp.Solved
{
    // https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    // Arrays: Left Rotation
    public class ArraysLeftRotation
    {
        //static void Main(string[] args)
        //{
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    int[] result = Process(a, k);
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.Write(result[i] + " ");
        //    }
        //}

        static int[] Process(int[] Array, int RotationCount)
        {
            // creation of array to hold result data
            int[] TempArray = new int[Array.Length];
            int IndexForArray = 0;

            // Finding real rotation count using mod
            if (RotationCount > Array.Length)
                RotationCount = RotationCount % Array.Length;

            for (int i = 0; i < Array.Length; i++)
            {
                if ((i + RotationCount) < Array.Length)
                    TempArray[i] = Array[i + RotationCount];
                else
                {
                    TempArray[i] = Array[IndexForArray++];
                }
            }
            return TempArray;
        }
    }


}
