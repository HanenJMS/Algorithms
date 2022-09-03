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
        public bool IsMemo { get; set; } = false;
        public void SetFibonacci() => currentProblem = new Fibonacci();
        public void SetGridTravler() => currentProblem = new GridTraveler();
        public ISolution GetCurrentSolution()
        {
            return currentProblem;
        }
        public void ToggleMemo()
        {
            IsMemo = !IsMemo;
            currentProblem.ToggleMemo(IsMemo);
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
