using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) 
            { 
                return false; 
            }
            var sum = 0;
            foreach (var number in numbers) 
            {
                if (number % 2 != 0) 
                {
                    sum += number;
                }
            }
            return (sum % 2 != 0)? true: false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    upper = true;
                }
                else if (char.IsLower(character))
                {
                    lower = true;
                }
                else if (char.IsNumber(character))
                {
                    number = true;
                }
            }
            return upper && lower && number;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0m : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (var i = 0; i < 100; i++) 
            {
                if (i % 2 != 0) 
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
