using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> (4){str1.Length, str2.Length, str3.Length, str4.Length};
            return list.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbersList = new List<int> { number1, number2, number3, number4 };
           return numbersList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // valid if sum of 2 sides is more than the other solo side
            // a+b >c
            // a+c>b
            // b+c>a

            if ((sideLength1 + sideLength2)> sideLength3 && (sideLength3 + sideLength2) > sideLength1 && (sideLength1 + sideLength3) > sideLength2)
            {
                return true;
            }
            return false;

        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var thing in objs)
            {
                if (thing == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var n = numbers.Where(x => x % 2 == 0);

            if (n.Count() != 0)
            {
                return n.Average();
            }

            return 0;

        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

           return number * Factorial(number - 1); 
        }
    }
}
