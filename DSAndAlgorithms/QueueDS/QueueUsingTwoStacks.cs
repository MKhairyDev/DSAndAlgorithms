using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.QueueDS
{
    /// <summary>
    ///https://www.hackerrank.com/challenges/queue-using-two-stacks/problem
    /// </summary>
    public class QueueUsingTwoStacksProblem
    {
        static void QueueUsingTwoStacks()
        {
            
                CustomQueue queue = new CustomQueue();
                int n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    string Line = Console.ReadLine();
                    int query = int.Parse(Line.Substring(0, 1));

                    if (query == 1)
                    {
                     
                        int num = int.Parse(Line.Substring(2));
                    queue.Enqueue(num);

                    }

                    else if (query == 2)
                    {
                        queue.Dequeue();
                    }
                    else
                    {
                        if (queue.Count > 0)
                            Console.WriteLine(queue.Peek());
                    }
                    n--;
                }
            
        }
            
        public static void Run()
        {
            QueueUsingTwoStacks();
        }
        public class CustomQueue
        {
            Stack<int> enqueuStack = new Stack<int>();
            Stack<int> dequeuStack = new Stack<int>();
            public int Count => dequeuStack.Count+ enqueuStack.Count;
            public void Enqueue(int item)
            {
                //while (dequeuStack.Count > 0)
                //{
                //    enqueuStack.Push(dequeuStack.Pop());
                //}
                enqueuStack.Push(item);
            }
            public int Dequeue()
            {

                if (dequeuStack.Count == 0)
                {
                    while (enqueuStack.Count > 0)
                    {
                        dequeuStack.Push(enqueuStack.Pop());
                    }
                }
                if (dequeuStack.Count > 0)
                    return  dequeuStack.Pop();
                throw new Exception("Empty Queue");
            }
            public int Peek()
            {
                if (dequeuStack.Count == 0)
                {
                    while (enqueuStack.Count > 0)
                    {
                        dequeuStack.Push(enqueuStack.Pop());
                    }
                }
                if(dequeuStack.Count>0)
                 return   dequeuStack.Peek();
                throw new Exception("Empty Queue");
            }
        }

    }
}
