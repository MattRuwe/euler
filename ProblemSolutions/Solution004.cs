using System;
using System.Collections.Generic;

namespace ProblemSolutions
{
    class Solution004 : SolutionBase
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        protected override string Solve(Action<string> feedback)
        {
            var palindromes = new List<int>();
            var largestPalindrome = 0;
            for(var x = 100; x < 1000;x++)
                for (var y = 100; y < 1000; y++)
                {
                    var valueToCheck = x*y;
                    if (IsPalindrome(valueToCheck))
                    {
                        palindromes.Add(valueToCheck);
                        if (valueToCheck > largestPalindrome)
                            largestPalindrome = valueToCheck;
                    }
                }

            return largestPalindrome.ToString();
        }

        private bool IsPalindrome(int candidate)
        {
            var candidateAsString = candidate.ToString();
            var candidateLength = candidateAsString.Length;
            var counter = 0;
            while(true)
            {
                if(candidateAsString.Substring(counter, 1) != candidateAsString.Substring(candidateLength - 1 - counter, 1))
                    return false;

                if (candidateLength/2 < counter)
                    return true;

                counter++;

            }

        }
    }
}