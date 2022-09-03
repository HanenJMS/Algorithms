using Algorithms.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Controls
{
    internal class Client
    {
        ISolution currentSolution;
        public object Run(object val)
        {
            if(int.TryParse(val as string, out int result))
            {
                return currentSolution.Run(result);
            }
            return "Invalid Inputs";
        }
        public void SolutionChange(ISolution solution)
        {
            currentSolution = solution;
        }

    }
}
