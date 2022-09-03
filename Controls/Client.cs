namespace Algorithms.Controls
{
    internal class Client
    {
        public ProblemController currentSolution { get; set; }
        public object Run(object val)
        {
            return currentSolution.Run(val);
        }
    }
}
