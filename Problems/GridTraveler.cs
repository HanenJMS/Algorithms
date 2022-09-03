using Algorithms.Interfaces;
using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    internal class GridTraveler : Problem, ISolution
    {
        public object Run(object num)
        {
            string[] numStrings = (num as string).Split(',');
            int[] numbers;
            int.TryParse(numStrings[0], out int result1);
            int.TryParse(numStrings[1], out int result2);
            numbers = new int[] { result1, result2 };
            if(IsMemo)
            {
                return RunMemo(numbers);
            }
            return RunNormal(numbers);
        }
        public int GridSequence(int row, int column)
        {
            if (row == 0 || column == 0) return 0;
            if (row <= 1 && column <= 1)
            {
                return 1;
            }
            return GridSequence(row - 1, column) + GridSequence(row, column - 1);
        }
        public ulong MemoSequence(int row, int column, Dictionary<object, ulong> memo)
        {
            object key = row + "," + column;
            if(memo.ContainsKey(key)) return memo[key];
            if (row == 0 || column == 0) return 0;
            if (row == 1 && column == 1) return 1;
            memo[key] = MemoSequence(row - 1, column, memo) + MemoSequence(row, column - 1, memo);
            return memo[key];
        }
        public override object RunMemo(object num)
        {
            int[] numbers = num as int[];
            Dictionary<object, ulong> memo = new Dictionary<object, ulong>();
            return MemoSequence(numbers[0], numbers[1], memo);
        }

        public override object RunNormal(object num)
        {
            int[] numbers = num as int[];
            return GridSequence(numbers[0], numbers[1]);
        }

        public string SpaceComplexity()
        {
            if(IsMemo)
            {
                return "O(n+m)";
            }
            return "O(6). Worse Case: O(n+m)";
        }

        public string TimeComplexity()
        {
            if (IsMemo)
            {
                return "m*n";
            }
            return "2^(n+m)";
        }

        public string Instructions()
        {
            return "Enter numbers in format: 1,2 not 1, 2 or 1 2";
        }
    }
}
