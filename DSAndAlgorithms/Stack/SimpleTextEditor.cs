using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Stack
{
    /// <summary>
    /*
     In this challenge, you must implement a simple text editor. Initially, your editor contains an empty string, . You must perform  operations of the following  types:

append - Append string  to the end of .
delete - Delete the last  characters of .
print - Print the  character of .
undo - Undo the last (not previously undone) operation of type  or , reverting  to the state it was in prior to that operation.
Input Format

The first line contains an integer, , denoting the number of operations.
Each line  of the  subsequent lines (where ) defines an operation to be performed. Each operation starts with a single integer,  (where ), denoting a type of operation as defined in the Problem Statement above. If the operation requires an argument,  is followed by its space-separated argument. For example, if  and , line  will be 1 abcd.

Constraints

The sum of the lengths of all  in the input .
The sum of  over all delete operations .
All input characters are lowercase English letters.
It is guaranteed that the sequence of operations given as input is possible to perform.
Output Format

Each operation of type  must print the  character on a new line.

Sample Input

8
1 abc
3 3
2 3
1 xy
3 2
4 
4 
3 1
Sample Output

c
y
a
Explanation

Initially,  is empty. The following sequence of  operations are described below:

. We append  to , so .
Print the  character on a new line. Currently, the  character is c.
Delete the last  characters in  (), so .
Append  to , so .
Print the  character on a new line. Currently, the  character is y.
Undo the last update to , making  empty again (i.e., ).
Undo the next to last update to  (the deletion of the last  characters), making .
Print the  character on a new line. Currently, the  character is a.
     */
    /// </summary>
    public class SimpleTextEditorProblem
    {
        static void SimpleTextEditor()
        {
            Stack<string> undoStack = new Stack<string>();
            StringBuilder s = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var query = Console.ReadLine();
                if (!string.IsNullOrEmpty(query))
                {
                    var arr = query.Split(' ');
                    int queryNum = int.Parse(arr[0]);
                    switch (queryNum)
                    {
                        case 1:
                            undoStack.Push(s.ToString());
                            string appendString = arr[1];
                            s .Append(appendString);
                            break;

                        case 2:
                            int k = int.Parse(arr[1]);
                            if (s.Length - k >= 0&& k<= s.Length)
                            {
                                undoStack.Push(s.ToString());

                                s.Remove((s.Length - k), k);
                            }
                            break;
                        case 3:
                            int kNum = int.Parse(arr[1]);
                            if (kNum <= s.Length && kNum > 0)
                            {
                                Console.WriteLine(s[kNum - 1]);
                            }
                            break;
                        case 4:
                            if (undoStack.Count > 0)
                            {
                                //string popItem = undoStack.Pop();
                                //s.Clear();
                                // s = new StringBuilder(undoStack.Pop());
                                s.Replace(s.ToString(), undoStack.Pop());
                            }
                            break;
                    }
                }
                n--;

            }
            // Stack<string> undoStack =new Stack<string>();
            // StringBuilder s = new StringBuilder();
            // int n =int.Parse(Console.ReadLine());
            // while (n>0)
            // {
            //var query=     Console.ReadLine();
            //     if (!string.IsNullOrEmpty(query))
            //     {
            //         var arr = query.Split(' ');
            //         int queryNum = int.Parse(arr[0]);
            //         switch (queryNum)
            //         {
            //             case 1:
            //                 undoStack.Push(s.ToString());
            //                 string appendString = arr[1];
            //                 s.Append(appendString);
            //                 break;

            //             case 2:
            //                 undoStack.Push(s.ToString());
            //                 int k = int.Parse(arr[1]);
            //                 s = s.Remove((s.Length - k), k);
            //                 break;
            //             case 3:
            //                 int kNum = int.Parse(arr[1]);
            //                 Console.WriteLine(s[kNum - 1]);
            //                 break;
            //             case 4:
            //                 if (undoStack.Count > 0)
            //                 {
            //                     string popItem = undoStack.Pop();
            //                     s = new StringBuilder(popItem);
            //                 }
            //                 break;

            //         }
            //     }
            //     n--;

            // }
        }

        public static void Run()
        {
            SimpleTextEditor();
        }
    }
}
