using System;

namespace ProblemSolutions
{
    class Solution003 : SolutionBase
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143?
        //Answer: 6857

        protected override string Solve(Action<string> feedback)
        {
            var largeNumber = 600851475143;

            long primeTrial = largeNumber;
            bool isPrime = false;
            do
            {
                primeTrial -= 2;
                var result = largeNumber % primeTrial;
                if (result == 0)
                    isPrime = IsPrime(primeTrial);
            } while (!isPrime);

            return primeTrial.ToString();
        }
    }
}
