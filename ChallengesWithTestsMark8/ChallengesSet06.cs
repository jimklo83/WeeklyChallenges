﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            if (ignoreCase)
            {
                word = word.ToLower();

                List<string> lower = words.Select(x => x.ToLower()).ToList();

                containsWord = lower.Contains(word);
            }
            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            
            if (num >= 0)
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if (num == 2 || num == 3)
            {
                isPrime = true;
            }
            if (num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if (uIndex)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }
            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
    }
}
