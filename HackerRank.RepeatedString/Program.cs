using System;
using System.IO;
using System.Linq;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        int lengthOfString = s.Length;
        if (lengthOfString.Equals(1) && s.Equals("a"))
            return n;

        long countOfA = s.Where(x => x.Equals('a')).Count();
        if (countOfA <= 0)
            return countOfA;

        long repeatCount = n / lengthOfString;
        long lengthOfRemaining = n % lengthOfString;

        if (lengthOfRemaining == 0)
            return repeatCount * countOfA;

        string toBeAddedString = s.Substring(0, Convert.ToInt32(lengthOfRemaining));
        return (repeatCount * countOfA) + toBeAddedString.Where(x => x.Equals('a')).Count();
    }
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        long result = repeatedString(s, n);
        Console.WriteLine("Result : " + result);
        Console.ReadLine();
    }
}
