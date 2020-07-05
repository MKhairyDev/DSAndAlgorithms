using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Stack
{
    /// <summary>
    /*
     You have three stacks of cylinders where each cylinder has the same diameter, but they may vary in height. You can change the height of a stack by removing and discarding its topmost cylinder any number of times.

Find the maximum possible height of the stacks such that all of the stacks are exactly the same height. This means you must remove zero or more cylinders from the top of zero or more of the three stacks until they're all the same height, then print the height. The removals must be performed in such a way as to maximize the height.

Note: An empty stack is still a stack.

Input Format

The first line contains three space-separated integers,n1 ,n2 ,n3 and , describing the respective number of cylinders in stacks 1,2 ,3 and .
The subsequent lines describe the respective heights of each cylinder in a stack from top to bottom:

The second line contains  space-separated integers describing the cylinder heights in stack . The first element is the top of the stack.
The third line contains  space-separated integers describing the cylinder heights in stack . The first element is the top of the stack.
The fourth line contains  space-separated integers describing the cylinder heights in stack . The first element is the top of the stack.
Constraints

Output Format

Print a single integer denoting the maximum height at which all stacks will be of equal height.

Sample Input

5 3 4
3 2 1 1 1
4 3 2
1 1 4 1
Sample Output

5
Explanation

Initially, the stacks look like this:

initial stacks

Observe that the three stacks are not all the same height. To make all stacks of equal height, we remove the first cylinder from stacks  and , and then remove the top two cylinders from stack  (shown below).

modified stacks

As a result, the stacks undergo the following change in height:

All three stacks now have . Thus, we print  as our answer.
     */
    /// </summary>
    public class EqualStacksProblem
    {
        static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            /*
             * Write your code here.
             */
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();
            int sum1 = GetSumAndFill(h1, stack1);
            int sum2 = GetSumAndFill(h2, stack2);
            int sum3 = GetSumAndFill(h3, stack3);
            int maxHeight = Math.Min(sum1, Math.Min(sum2, sum3));
            while (sum1!=sum2|| sum1 != sum3)
            {
                if(sum1>maxHeight)
                {
                    sum1 = sum1 - stack1.Pop();
                    maxHeight =Math.Min( sum1,maxHeight);
                }
                if (sum2 > maxHeight)
                {
                    sum2 = sum2 - stack2.Pop();
                    maxHeight = Math.Min(sum2, maxHeight);
                }
                if (sum3 > maxHeight)
                {
                    sum3 = sum3 - stack3.Pop();
                    maxHeight = Math.Min(sum3, maxHeight);
                }
            }
            return maxHeight;
        }
        private static int GetSumAndFill(int[] h,Stack<int>stack)
        {
            int sum = 0;
            for (int i = h.Length-1; i >=0; i--)
            {
                sum += h[i];
                stack.Push(h[i]);
            }
            return sum;
        }
        public static void Run()
        {
            string[] n1N2N3 = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);

            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp)) ;

            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp));

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp));

            int result = equalStacks(h1, h2, h3);
        }
    }
}
