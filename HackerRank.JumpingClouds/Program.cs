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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int numberJump = 0;
        for (int i = 0; i < c.Length - 1; i++)
        {
            if (i.Equals(c.Length - 1))
                continue;
            if (c[i].Equals(0) && (i + 2 == c.Length))
                numberJump++;
            else
            {
                if (c[i + 2].Equals(0))
                    i = i + 1;
                numberJump++;
            }
        }
        return numberJump;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        Console.WriteLine("Result : " + result);
        Console.ReadLine();
    }
}
