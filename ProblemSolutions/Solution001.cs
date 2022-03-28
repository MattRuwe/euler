using System;

namespace ProblemSolutions;

class Solution001 : SolutionBase
{
    protected override string Solve(Action<string> feedback)
    {
        var total = 0;
        for (var i = 0; i < 1000; i++)
            if (i%3 == 0 || i%5 == 0)
                total += i;

        return total.ToString();
    }
}