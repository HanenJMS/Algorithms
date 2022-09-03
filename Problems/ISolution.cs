using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal interface ISolution
    {
        object Run(object val);
        string TimeComplexity();
        string SpaceComplexity();
    }
}
