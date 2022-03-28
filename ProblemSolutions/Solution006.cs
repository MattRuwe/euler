using System;

namespace ProblemSolutions
{
    class Solution006 : SolutionBase
    {
        protected override string Solve(Action<string> feedback)
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (int)Math.Pow(i, 2);
            }

            int squareOfSums = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSums += i;
            }
            squareOfSums = (int)Math.Pow(squareOfSums, 2);

            var result = squareOfSums - sumOfSquares;

            return result.ToString();
        }
    }
}