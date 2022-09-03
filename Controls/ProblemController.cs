using Algorithms.Interfaces;
using Algorithms.Problems;

namespace Algorithms.Controls
{
    sealed class ProblemController
    {
        private static ProblemController _instance { get; set; }
        public static ProblemController Instance
        {
            get
            {
                if (_instance == null) return new ProblemController();
                return _instance;
            }
        }
        ISolution currentProblem;
        public bool IsMemo { get; set; } = false;
        public object Run(object val)
        {
            return currentProblem.Run(val);
        }
        public void SetSolution(ISolution solution)
        {
            currentProblem = solution;
        }
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
        public void SetFibonacci()
        {
            currentProblem = new Fibonacci();
        }
        public void SetGridTraveler()
        {
            currentProblem = new GridTraveler();
        }
        public void SetCanSum()
        {
            currentProblem = new CanSum();
        }
        public string Instructions()
        {
            return currentProblem.Instructions();
        }
    }
}
