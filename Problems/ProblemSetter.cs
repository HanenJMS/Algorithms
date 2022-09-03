using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal class ProblemSetter
    {
        ISolution currentProblem;
        public void SetFibonacci()
        {
            currentProblem = new Fibonacci();
        }
        public ISolution GetCurrentSolution()
        {
            return currentProblem;
        }
        public string TimeComplexity()
        {
            return currentProblem.TimeComplexity();
        }
        public string SpaceComplexity()
        {
            return currentProblem.SpaceComplexity();
        }
    }
}
