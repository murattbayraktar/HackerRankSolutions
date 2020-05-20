using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.ConsoleApp.Solved
{
    //https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
    //Strings: Making Anagrams
    class StringsMakingAnagrams
    {
        //static void Main(string[] args)
        //{
        //    string a = Console.ReadLine();
        //    string b = Console.ReadLine();
        //    int Result = Process(a, b);
        //    Console.WriteLine(Result);
        //}

        static int Process(string FirstWord, string SecondWord)
        {
            Dictionary<char, int> FirstCharList = new Dictionary<char, int>();
            Dictionary<char, int> SecondCharList = new Dictionary<char, int>();
            char Item;
            int CharCountFirst = 0;
            int CharCountSecond = 0;
            int TotalDelete = 0;

            for (int i = 0; i < FirstWord.Length; i++)
            {
                Item = FirstWord[i];
                if (FirstCharList.Keys.Contains(Item))
                    FirstCharList[Item] += 1;
                else
                    FirstCharList.Add(Item, 1);
            }

            for (int i = 0; i < SecondWord.Length; i++)
            {
                Item = SecondWord[i];
                if (SecondCharList.Keys.Contains(Item))
                    SecondCharList[Item] += 1;
                else
                    SecondCharList.Add(Item, 1);
            }


            for (int i = 0; i < FirstCharList.Values.Count; i++)
            {
                Item = FirstCharList.ElementAt(i).Key;
                CharCountFirst = FirstCharList.ElementAt(i).Value;

                if (SecondCharList.Keys.Contains(Item))
                {
                    CharCountSecond = SecondCharList[Item];

                    if (!(CharCountFirst == CharCountSecond))
                        TotalDelete = TotalDelete + Math.Abs(CharCountSecond - CharCountFirst);

                    SecondCharList.Remove(Item);
                }

                // If character is not match then it must be deleted.
                else
                    TotalDelete = TotalDelete + CharCountFirst;
            }

            // All items must be deleted in the second charlist. First charlist has not contain this characters.
            TotalDelete = TotalDelete + SecondCharList.Values.Sum();
            return TotalDelete;

        }
    }
}
