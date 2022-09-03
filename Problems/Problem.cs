using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal abstract class Problem
    {
        public bool IsMemo { get; set; } = false;
        public void ToggleMemo(bool IsMemo)
        {
            this.IsMemo = IsMemo;
        }
    }
}
