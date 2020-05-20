using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.ConsoleApp
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> Values = new List<string>();
            List<string> SearchParameters = new List<string>();

            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];
                if(op.Contains("add"))
                    Values.Add(contact);
                if (op.Contains("find"))
                    SearchParameters.Add(contact);
            }

            List<int> Results = Process(Values,SearchParameters);
            for (int i = 0; i < Results.Count; i++)
            {
                Console.WriteLine(Results[i]);
            }

            Console.ReadLine();
        }

        public static List<int> Process(List<string> Contacts, List<string> Filters)
        {
            List<int> ResultList = new List<int>();
            int Count = 0;

            for (int i = 0; i < Filters.Count; i++)
            {
                Count = Contacts.Where(x => x.StartsWith(Filters[i])).Count();
                ResultList.Add(Count);
            }
            
            return ResultList;
        }
    }
}
