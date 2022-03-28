using System;

namespace ProblemSolutions
{
    class Solution010 : SolutionBase
    {
        protected override string Solve(Action<string> feedback)
        {
            var total = 2;
            for (int i = 3; i < 2000000; i+=2)
            {
                if (IsPrime(i))
                    total += i;
            }

            return total.ToString();
        }
    }
}