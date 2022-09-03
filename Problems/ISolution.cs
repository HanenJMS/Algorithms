using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal interface ISolution
    {
        void ToggleMemo(bool IsMemo);
        object Run(object num);
        string TimeComplexity();
        string SpaceComplexity();
    }
}
