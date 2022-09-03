using Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal class CanSum : Problem, ISolution
    {
        public string Instructions()
        {
            return "Enter an Array of numbers: 1, 2, 3, 4. \nWrite on new line for target.";
        }
        public int NormalSequence(int[] arr, int target)
        {
            return 1;
        }
        public object Run(object num)
        {
            if(IsMemo)
            {
                return RunMemo(num);
            }
            return RunNormal(num);
        }

        public override object RunMemo(object num)
        {
            throw new NotImplementedException();
        }

        public override object RunNormal(object num)
        {
            string[] strings = num as string[];
            string[] row = strings[0].Split(',');
            int[] arr = new int[row.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(row[i]);
            }
            int.TryParse(strings[1], out int target);
            return NormalSequence(arr, target);
        }

        public string SpaceComplexity()
        {
            throw new NotImplementedException();
        }

        public string TimeComplexity()
        {
            throw new NotImplementedException();
        }
    }
}
