using Algorithms.Interfaces;

namespace Algorithms.Problems
{
    internal abstract class Problem
    {
        public bool IsMemo { get; set; } = false;
        public void ToggleMemo(bool IsMemo)
        {
            this.IsMemo = IsMemo;
        }
        public abstract object RunNormal(object num);
        public abstract object RunMemo(object num);
    }
}
