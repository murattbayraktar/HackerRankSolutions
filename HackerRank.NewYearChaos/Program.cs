using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        string resultMessage = string.Empty;
        int countOfStep = 0;
        bool hasError = false;
        int[] firstArray = new int[q.Length];

        for (int i = 0; i < q.Length; i++)
        {
            firstArray[i] = i + 1;
        }

        for (int i = 0; i < q.Length -1; i++)
        {
            if (q[i] == firstArray[i])
                continue;

            if (Math.Abs(q[i] - firstArray[i]) > 2)
            {
                resultMessage = "Too chaotic";
                hasError = true;
                break;
            }

            int shouldBeitem = firstArray[i];
            int indexOfItem = q.ToList().IndexOf(firstArray[i]);

            int difference = Convert.ToInt32(Math.Abs(i - indexOfItem));
            if (difference > 2)
            {
                resultMessage = "Too chaotic";
                hasError = true;
                break;
            }
            else
            {
                int val = q[i];
                q[i] = firstArray[i];
                q[indexOfItem] = val; 
                countOfStep += 1;
            }
        }

        if(hasError)
            Console.WriteLine(resultMessage);
        else
            Console.WriteLine(countOfStep);

        Console.ReadLine();
    }
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
