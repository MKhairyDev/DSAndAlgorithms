using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Stack
{
    /// <summary>
    /*
     You have an empty sequence, and you will be given  queries. Each query is one of these three types:

1 x  -Push the element x into the stack.
2    -Delete the element present at the top of the stack.
3    -Print the maximum element in the stack.
Input Format

The first line of input contains an integer, . The next  lines each contain an above mentioned query. (It is guaranteed that each query is valid.)

Constraints



Output Format

For each type  query, print the maximum element in the stack on a new line.

Sample Input

10
1 97
2
1 20
2
1 26
1 20
2
3
1 91
3
Sample Output

26
91
     */
    /// </summary>
    public class MaximumElementProblem
    {
        public static void MaximumElement()
        {
            Stack<StackDto> stack = new Stack<StackDto>();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string Line = Console.ReadLine();
                int query = int.Parse(Line.Substring(0, 1));

                if (query == 1)
                {
                    int max = 0;
                    int num = int.Parse(Line.Substring(2));
                    if (stack.Count == 0)
                    {
                        max = num;
                    }
                    else
                    {
                        max = Math.Max(num, stack.Peek().Max);
                    }

                    stack.Push(new StackDto(num, max));

                }

                else if (query == 2)
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    if (stack.Count > 0)
                        Console.WriteLine(stack.Peek().Max);
                }
                n--;
            }

        }
   public class StackDto
{
    public int Value { get; set; }
    public int Max { get; set; }
    public StackDto(int value, int max)
    {
        Value = value;
        Max = max;
    }
}
public static void Run()
        {
            MaximumElement();
        }
    }
}
