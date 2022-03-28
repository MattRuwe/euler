using System;
using System.Collections.Generic;

namespace ProblemSolutions
{
    class Solution007 : SolutionBase
    {
        protected override string Solve(Action<string> feedback)
        {
            var primes = new List<int>() {2};
            var counter = 3;
            while (true)
            {
                if(IsPrime(counter))
                    primes.Add(counter);

                if (primes.Count == 10001)
                    return counter.ToString();

                counter += 2;
            }
        }
    }
}