using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal class Fibonacci : Problem, ISolution
    {
        public int FibSequence(int n)
        {
            if(n <= 2)
            {
                return 1;
            }
            return FibSequence(n - 1) + FibSequence(n - 2);
        }
        public int MemoSequence(int n, Dictionary<int, int> memo)
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
            if(IsMemo)
            {
                return RunMemo(num);
            }
            return RunNormal(num);
        }

        public object RunMemo(object num)
        {
            int n = (int)num;
            Dictionary<int, int> memo = new Dictionary<int, int>();
            return MemoSequence(n, memo);
        }

        public object RunNormal(object num)
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
