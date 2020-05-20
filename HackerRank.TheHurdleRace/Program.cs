using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
            int result = hurdleRace(k, height);
        }

        static int hurdleRace(int k, int[] height)
        {
            int maximumDifference = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > k && maximumDifference < height[i] - k)
                  maximumDifference = height[i] - k;
            }

            return maximumDifference;
        }
    }
}
