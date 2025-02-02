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
    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        const string Up = "U";
        const string Down = "D";
        int counterValley = 0;
        int counterLevel = 0;

        foreach (char item in s)
        {
            if (item.ToString().Equals(Up))
            {
                if((counterLevel+1).Equals(0))
                    counterValley++;
                counterLevel++;
            }
            else if (item.ToString().Equals(Down))
                counterLevel--;
            else
                continue;
        }
        return counterValley;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine("Result : " + result);
        Console.ReadLine();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
