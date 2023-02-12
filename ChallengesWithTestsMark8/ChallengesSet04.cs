using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else
            {
                int total = 0;
                foreach (int num in numbers) 
                    total += num%2 == 0 ? num : -num;
                return total;
            }

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> sLengths= new List<int>();
            sLengths.Add(str1 == null ? 0 : str1.Length);
            sLengths.Add(str2 == null ? 0 : str2.Length);
            sLengths.Add(str3 == null ? 0 : str3.Length);
            sLengths.Add(str4 == null ? 0 : str4.Length);
            return sLengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int minVal = number1;
            minVal = number2 < minVal ? number2 : minVal;
            minVal = number3 < minVal ? number3 : minVal;
            minVal = number4 < minVal ? number4 : minVal;
            return minVal;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 < sideLength2 + sideLength3)
                if (sideLength2 < sideLength1 + sideLength3)
                    if (sideLength3 < sideLength1 + sideLength2)
                        return true;
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrEmpty(input)) 
                return false;
            else if (decimal.TryParse(input,out decimal result))
                return true;
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs==null || objs.Count()==0) 
                return true;
            else
            {
                int ctNulls = 0;
                foreach (var o in objs) 
                    if (o == null) 
                        ctNulls++;
                if (ctNulls > objs.Count() / 2) 
                    return true;
                else
                    return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers==null)
                return 0;
            else
            {
                List<double> evens = new List<double>();
                foreach (int n in numbers)
                    if (n % 2 == 0)
                        evens.Add(n);
                if (evens.Count()>0)
                    return evens.Average();
                else
                    return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else if (number < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                int factorial = number;
                for (int i = number - 1; i > 0; i--)
                    factorial *= i;
                return factorial;
            }
        }
    }
}
