using Algorithms.Controls;
using Algorithms.Interfaces;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    internal class Fibonacci : Problem, ISolution
    {
        public int FibSequence(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return FibSequence(n - 1) + FibSequence(n - 2);
        }

        public string Instructions()
        {
            return "enter whole numbers. i.e. 123 not 12.3 or 12,3";
        }

        public uint MemoSequence(int n, Dictionary<int, uint> memo)
        {
            if (memo.ContainsKey(n)) return memo[n];
            if (n <= 2)
            {
                return 1;
            }
            memo[n] = MemoSequence(n - 1, memo) + MemoSequence(n - 2, memo);
            return memo[n];
        }

        public object Run(object num)
        {
            if (int.TryParse(num as string, out int result))
            {
                if (IsMemo)
                {
                    return RunMemo(result);
                }
                return RunNormal(result);
            }
            return "Invalid Input";
        }

        public override object RunMemo(object num)
        {
            int n = (int)num;
            Dictionary<int, uint> memo = new Dictionary<int, uint>();
            return MemoSequence(n, memo);
        }

        public override object RunNormal(object num)
        {
            int n = (int)num;
            return FibSequence(n);
        }
        public string SpaceComplexity()
        {
            if (IsMemo) return "n";
            return "n";
        }
        public string TimeComplexity()
        {
            if (IsMemo) return "n";
            return "2^n";
        }
    }
}
