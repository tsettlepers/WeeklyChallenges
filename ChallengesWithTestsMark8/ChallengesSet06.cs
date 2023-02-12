using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words==null || words.Count()==0) 
                return false;
            else if (string.IsNullOrEmpty(word)) 
                return false;
            else
            {
                foreach (string w in words)
                    if (w != null)
                        if ((ignoreCase && w.ToUpper() == word.ToUpper()) || (w == word))
                            return true;
                return false;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num<2)
                return false;
            else
            {
                for (int i = num - 1; i > 1; --i)
                    if (num % i == 0)
                        return false;
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return -1;
            else
            {
                int maxNdx = -1;
                foreach (char c in str)
                {
                    if (str.IndexOf(c)==str.LastIndexOf(c))
                        if (str.IndexOf(c)>maxNdx)
                            maxNdx = str.IndexOf(c);
                }
                return maxNdx;
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            else
            {
                int maxConsec = 1;
                int thisConsec = 1;
                int thisVal = numbers[0];
                for (int i = 1; i < numbers.Length; ++i)
                {
                    if (numbers[i] == thisVal)
                    {
                        ++thisConsec;
                        if (thisConsec > maxConsec)
                            maxConsec = thisConsec;
                    }
                    else
                    {
                        thisConsec = 1;
                        thisVal = numbers[i];
                    }
                }
                return maxConsec;
            }
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if (elements!=null && elements.Count>0 && n>0 && n<=elements.Count)
            {
                for (int i=n-1; i<elements.Count; i+=n)
                    result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
