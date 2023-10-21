using System;
using System.Collections.Generic;
using System.Linq;

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
            var shortest = new List<string>() { str1, str2, str3, str4 };
            shortest = shortest.OrderBy(x => x.Length).ToList();
            return shortest[0].Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallest = new List<int>() { number1, number2, number3, number4 };
            smallest = smallest.OrderBy(x => x).ToList();
            return smallest[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;
            return (a + b > c && b + c > a && a + c > b) ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            return (double.TryParse(input, out double number)) ? true : false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nulls++;
                }
            }
            return (nulls > (objs.Length / 2)) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || !numbers.Any(x => x % 2 == 0))
            {
                return 0;
            }
            double average = numbers.Where(x => x % 2 == 0).Average();
            return average;
        }

        public int Factorial(int number)
        {
            int factorial = 1;
            
            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException("Input must be non-negative."); 
            }
            if (number == 0)
            {
                return 1;
            }
            for (int i = number; i > 0; i--) 
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
