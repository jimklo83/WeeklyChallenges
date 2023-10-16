using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else 
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortestString = 0;
            if (str1.Length < str2.Length) 
            {
                shortestString = str1.Length;
            }
            else
            {
                shortestString = str2.Length;
            }
            if (str3.Length < shortestString) 
            {
                shortestString = str3.Length;
            }
            if (str4.Length < shortestString) 
            {
                shortestString = str4.Length;
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallestNumber = 0;
            if (number1 < number2)
            {
                smallestNumber = number1;
            }
            else 
            {
                smallestNumber = number2;
            }
            if (number3 < smallestNumber) 
            {
                smallestNumber = number3;
            }
            if (number4 < smallestNumber) 
            {
                smallestNumber = number4;
            }
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double result);    
            return (isNumber) ? true : false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = 0;
            var nonNulls = 0;
            foreach (var obj in objs) 
            {
                if (obj == null)
                {
                    nulls++;
                }
                else 
                {
                    nonNulls++;
                }
            }
            return (nulls > nonNulls) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            double amount = 0;
            double sum = 0;
            if (numbers == null || numbers.Length == 0) 
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    amount++;
                    sum += number;
                }
            }
            return (sum == 0) ? 0:  sum / amount;
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
