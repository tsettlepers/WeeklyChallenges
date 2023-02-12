using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals== null || vals.Length == 0)
                return false;
            else
            {
                foreach (var booVal in vals)
                    if (booVal == false)
                        return true;
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers==null)
                return false;
            else
            {
                int sumOdds = 0;
                foreach (var numVal in numbers)
                    if (numVal % 2 != 0) 
                        sumOdds += numVal;
                return sumOdds % 2 != 0 ? true : false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password)) 
                return false;
            else
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasNumber = false;

                foreach (char c in password)
                {
                    if (c >= 'a' && c <= 'z') hasLower = true;
                    if (c >= 'A' && c <= 'Z') hasUpper = true;
                    if (c >= '0' && c <= '9') hasNumber = true;
                }
                return hasUpper & hasLower & hasNumber;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
                return '\0';
            else
                return Convert.ToChar(val.Substring(0,1));
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
                return '\0';
            else
                return Convert.ToChar(val.Substring(val.Length-1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums==null)
                return 0;
            else if (nums.Count()==0)
                return 0;
            else
            {
                return nums[nums.Count()-1] - nums[0];
            }
        }

        public int[] GetOddsBelow100()
        {
            List<int> lstNums = new List<int>();
            for (int i=1; i<100; i+=2)
                lstNums.Add(i);
            return lstNums.ToArray<int>();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
                return;
            else if (words.Count() == 0)
                return;
            else
            {
                for (int i=0; i<words.Count(); ++i)
                    words[i] = words[i].ToUpper();
                return;
            }
        }
    }
}
