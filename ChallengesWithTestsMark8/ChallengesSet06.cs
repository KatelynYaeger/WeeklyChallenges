using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> newList = (words.Select(x => x.ToLower()).ToList());
                containsWord = newList.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <=1)
            {
                return false;
            }

            var primeCount = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    primeCount++;
                }
            }
            if (primeCount == 2)
            {
                return true;
            }
                return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
            }
            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
           var matchingCount = 0;

           for (int i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;

                    for (int j = 1+i; j < numbers.Length; j++)
                    {
                        if (numbers[i] != numbers[j] && i != j)
                        {
                        break;
                        }
                    currentCount++;
                    }
                    if (currentCount > matchingCount)
                {
                    matchingCount = currentCount;
                }
                
            }
            return matchingCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 0)
            {
                return new double[0];
            }

            var nList = new List<double>();

            for (int i = n-1; i < elements.Count; i += n)
            {
                nList.Add(elements[i]);
            }

            return nList.ToArray();
        }
    }
}
