using System;

namespace ProblemSolutions
{
    class Solution005 : SolutionBase
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        protected override string Solve(Action<string> feedback)
        {
            int currentNumber = 1;
            bool success = false;
            while (!success)
            {
                for (var i = 1; i <= 20; i++)
                {
                    if (currentNumber%i != 0)
                    {
                        currentNumber++;
                        break;
                    }
                    if (i == 20)
                        success = true;
                }
            }

            return currentNumber.ToString();
        }
    }
}