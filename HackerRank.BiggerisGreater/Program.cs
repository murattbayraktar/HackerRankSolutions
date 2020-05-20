using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.BiggerisGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[T];

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();
                words[0] = w;
            }

            for (int i = 0; i < words.Length; i++)
            {
                string result = biggerIsGreater(words[i]);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        static string biggerIsGreater(string w)
        {
            int wordLength = w.Length;
            bool isFound = false;
            string result = string.Empty;

            if (wordLength <= 1)
                return "no answer";

            int iterator = wordLength - 1;
            int index = 0;
            while (iterator > 0)
            {
                if (w[iterator] > w[iterator - 1])
                {
                    index = iterator - 1;
                    isFound = true;
                    break;
                }
                iterator -= 1;
            }

            if (isFound)
                result = foundedProcess(w, index);
            else
                result = "no answer";

            return result;
        }

        public static string foundedProcess(string w, int indexOfBigNumber)
        {
            StringBuilder sb = new StringBuilder(w);

            char toChanged = w[indexOfBigNumber];

            int[] array = w.AsQueryable().Where(x => x != toChanged).Select(x => (int)x).ToArray().Where(x => x > w[indexOfBigNumber]).ToArray();

            int minValueToChange = array.Min();

            if (minValueToChange <= w[indexOfBigNumber])
                return "no answer";

            int firstIndexOfChangedItem = w.IndexOf((char)minValueToChange);
            sb[firstIndexOfChangedItem] = w[indexOfBigNumber];
            char tempOldValue = w[indexOfBigNumber];
            w = sb.ToString();

            string changedWord = w.Substring(0, indexOfBigNumber) + (char)minValueToChange + w.Substring(indexOfBigNumber + 1, firstIndexOfChangedItem - 1) + tempOldValue; 
            if(firstIndexOfChangedItem < w.Length)
                changedWord += w.Substring(firstIndexOfChangedItem + 1, w.Length - (firstIndexOfChangedItem + 1));
            
            return changedWord.Substring(0,indexOfBigNumber + 1) + organizeNumberToSmallest(changedWord.Substring(indexOfBigNumber + 1, w.Length - (indexOfBigNumber + 1)));
        }

        private static string organizeNumberToSmallest(string v)
        {
            int[] array = v.AsQueryable().Select(x => (int)x).OrderBy(o => (int)o).ToArray();
            return new string(array.AsQueryable().Select(x => (char)x).ToArray());
        }
    }
}
