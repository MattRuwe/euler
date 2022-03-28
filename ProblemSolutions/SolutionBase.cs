using System;

namespace ProblemSolutions
{
    abstract class SolutionBase
    {

        public void InternalMain()
        {
            var answer = Solve(Console.WriteLine);

            Console.WriteLine("Done!");
            Console.WriteLine(answer);
            Console.ReadKey(true);
        }

        public string GetSolutionResult()
        {
            var answer = Solve(Console.WriteLine);

            return answer;
        }

        protected abstract string Solve(Action<string> feedback);

        protected static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}