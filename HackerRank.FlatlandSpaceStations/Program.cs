using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.FlatlandSpaceStations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = flatlandSpaceStations(n, c);

            Console.ReadLine();
        }

        //static int flatlandSpaceStations(int n, int[] c)
        //{
        //    int cityCount = n;
        //    int stationCount = c.Length;
        //    Array.Sort(c);
        //    int[] stationCities = c;

        //    if (cityCount.Equals(stationCount))
        //        return 0;

        //    int[] distancesByCity;
        //    int[] allDistances = new int[cityCount];

        //    for (int i = 0; i < cityCount; i++)
        //    {
        //        distancesByCity = new int[stationCount];

        //        for (int x = 0; x < stationCities.Length; x++)
        //        {
        //            distancesByCity[x] = Math.Abs(stationCities[x] - i);               
        //        }

        //        Array.Sort(distancesByCity);
        //        allDistances[i] = distancesByCity[0]; 
        //    }

        //    Array.Sort(allDistances);
        //    Array.Reverse(allDistances);
        //    return allDistances[0];
        //}

        static int flatlandSpaceStations(int n, int[] c)
        {
            int cityCount = n;
            int stationCount = c.Length;
            int maximumDistance = 0;

            if (cityCount.Equals(stationCount))
                return 0;

            Array.Sort(c);
            int[] stationCities = c;

            for (int i = 0; i < cityCount; i++)
            {
                int minimumDistanceByCity = 0;
                for (int x = 0; x < stationCities.Length; x++)
                {
                    int currentDistance;
                    if (x == 0)
                        currentDistance = minimumDistanceByCity = Math.Abs(stationCities[x] - i);
                    else
                        currentDistance = Math.Abs(stationCities[x] - i);

                    if (currentDistance < minimumDistanceByCity)
                        minimumDistanceByCity = currentDistance;
                }

                if (minimumDistanceByCity > maximumDistance)
                    maximumDistance = minimumDistanceByCity;
            }

            return maximumDistance;
        }

    }
}
