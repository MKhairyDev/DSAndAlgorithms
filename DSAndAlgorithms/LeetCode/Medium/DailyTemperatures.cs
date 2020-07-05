using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Medium
{
    /// <summary>
    /*
 Given a list of daily temperatures T, return a list such that, for each day in the input, tells you how many days you would have to wait until a warmer temperature. If there is no future day for which this is possible, put 0 instead.

For example, given the list of temperatures T = [73, 74, 75, 71, 69, 72, 76, 73], your output should be [1, 1, 4, 2, 1, 1, 0, 0].

Note: The length of temperatures will be in the range [1, 30000]. Each temperature will be an integer in the range [30, 100].
 */
    /// </summary>
    public class DailyTemperaturesProblem
    {
        /// <summary>
        /*
         As in Approach #1, process indices i in descending order. We'll keep a stack of indices such that T[stack[-1]] < T[stack[-2]] < ..., where stack[-1] is the top of the stack, stack[-2] is second from the top, and so on; and where stack[-1] > stack[-2] > ...; and we will maintain this invariant as we process each temperature.

After, it is easy to know the next occurrence of a warmer temperature: it's simply the top index in the stack.

Here is a worked example of the contents of the stack as we work through T = [73, 74, 75, 71, 69, 72, 76, 73] in reverse order, at the end of the loop (after we add T[i]). For clarity, stack only contains indices i, but we will write the value of T[i] beside it in brackets, such as 0 (73).

When i = 7, stack = [7 (73)]. ans[i] = 0.
When i = 6, stack = [6 (76)]. ans[i] = 0.
When i = 5, stack = [5 (72), 6 (76)]. ans[i] = 1.
When i = 4, stack = [4 (69), 5 (72), 6 (76)]. ans[i] = 1.
When i = 3, stack = [3 (71), 5 (72), 6 (76)]. ans[i] = 2.
When i = 2, stack = [2 (75), 6 (76)]. ans[i] = 4.
When i = 1, stack = [1 (74), 2 (75), 6 (76)]. ans[i] = 1.
When i = 0, stack = [0 (73), 1 (74), 2 (75), 6 (76)]. ans[i] = 1.

                     Complexity Analysis

Time Complexity: O(N), where N is the length of T and WW is the number of allowed values for T[i]. Each index gets pushed and popped at most once from the stack.

Space Complexity: O(W). The size of the stack is bounded as it represents strictly increasing temperatures.
         */
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public static int[] DailyTemperatures(int[] T)
        {
            int[] res = new int[T.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = T.Length - 1; i >= 0; --i)
            {
                while (stack.Count > 0 && T[i] >= T[stack.Peek()])
                {
                    stack.Pop();
                }
                res[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }
            return res;

        }
        public static void Run()
        {
            var res = DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
            var res2 = DailyTemperatures(new int[] { 77, 74, 75, 71, 69, 72, 76, 73 });
            var res3 = DailyTemperatures(new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 });
        }
    }
}
