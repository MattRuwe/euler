using System;

namespace ProblemSolutions
{
    class Solution009 : SolutionBase
    {
        protected override string Solve(Action<string> feedback)
        {
            int a = 0, b = 1, c = 3;
            bool aDone = false;
            bool bDone = false;
            bool cDone = false;

            for (a = 1; a < 1000; a++)
            {
                for (b = a + 1; !bDone; b++)
                {
                    if (b > 999)
                    {
                        bDone = true;
                    }
                    for (c = b + 1; !cDone; c++)
                    {
                        if (a + b + c > 1000)
                            cDone = true;
                        else if (a + b + c == 1000 && (int) (Math.Pow(a, 2) + Math.Pow(b, 2)) == (int) Math.Pow(c, 2))
                        {
                            return (a*b*c).ToString();
                        }
                    }
                    cDone = false;
                }
                bDone = false;
            }
            return "";
        }
    }
}