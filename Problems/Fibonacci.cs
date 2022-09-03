using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal class Fibonacci : ISolution
    {
        public int FibSequence(int n)
        {
            if(n <= 2)
            {
                return 1;
            }
            return FibSequence(n - 1) + FibSequence(n - 2);
        }

        public object Run(object num)
        {
            int n = (int)num;
            return FibSequence(n);
        }

        public string SpaceComplexity()
        {
            return "n";
        }

        public string TimeComplexity()
        {
            return "2^n";
        }
    }
}
