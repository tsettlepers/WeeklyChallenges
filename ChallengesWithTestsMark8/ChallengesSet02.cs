using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return ((c>='a' && c<='z')||(c>='A' && c<='Z') ? true : false);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null)
                return 0; 
            else if (numbers.Count() == 0)
                return 0;
            else
                return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1))
                return 0;
            else if (String.IsNullOrEmpty(str2))
                return 0;
            else
                return str1.Length<str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers==null)
                return 0;
            else
                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers==null)
                return 0;
            else
            {
                int sumOfEvens = 0;
                foreach (int n in numbers)
                    if (n%2 == 0) sumOfEvens+=n;
                return sumOfEvens;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            else if (numbers.Count() == 0)
                return false;
            else
                return numbers.Sum() % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1) 
                return 0;
            else
                return number / 2;
        }
    }
}
