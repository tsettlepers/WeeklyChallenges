using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                int prevFactor = startNumber / n;
                return (prevFactor + 1) * n;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses != null)
            {
                foreach (Business biz in businesses)
                    if (biz.TotalRevenue == 0.0)
                        biz.Name = "CLOSED";
            }
            return;
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers==null || numbers.Length == 0) 
                return false;
            else
            {
                for (int i = 1; i < numbers.Length; ++i)
                    if (numbers[i] < numbers[i - 1])
                        return false;
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers==null || numbers.Length==0)
                return 0;
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length - 1; ++i)
                    if (numbers[i] % 2 == 0)
                        sum += numbers[i + 1];
                return sum;
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            else
            {
                string sentence = "";
                foreach (string w in words)
                    sentence = sentence.Trim() + " " + w.Trim();
                return sentence.Trim() + (sentence.Trim() == "" ? "" : ".");
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (elements!=null && elements.Count>0) 
                for (int i=3; i<elements.Count; i+=4)
                    result.Add(elements[i]);
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums != null && nums.Length > 0)
                for (int outer = 0; outer < nums.Length - 1; outer++)
                    for (int inner = outer + 1; inner < nums.Length; inner++)
                        if (nums[outer] + nums[inner] == targetNumber)
                            return true;
            return false;
        }
    }
}
