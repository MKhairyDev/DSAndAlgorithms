using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Stack
{
    /// <summary>
    /*
     * URL:https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
     */
    /// </summary>
    public class DeleteNodeProblem
    {
        static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            if (position == 0)
                return head.next;
            int count = 0;
            var newHead = head;
            while (head != null && count < position)
            {
                if (count == position - 1)
                {
                    var temp = head.next.next;
                    head.next = temp;
                    return newHead;
                }
                count++;

                head = head.next;
            }
            return null;
        }

        public static void Run()
        {
            var node9 = new SinglyLinkedListNode(9, null);
            var node15 = new SinglyLinkedListNode(15, node9);
            var node4 = new SinglyLinkedListNode(4, node15);
            var node7 = new SinglyLinkedListNode(7, node4);
            var node19 = new SinglyLinkedListNode(19, node7);
            var node2 = new SinglyLinkedListNode(2, node19);
            var node6 = new SinglyLinkedListNode(6, node2);
            var nodeHead = new SinglyLinkedListNode(20, node6);

            var res = DeleteNode(nodeHead, 3);
        }

        public class SinglyLinkedListNode
        {
            public SinglyLinkedListNode(int data, SinglyLinkedListNode next)
            {
                this.Data = data;
                this.next = next;
            }
            public int Data;
            public SinglyLinkedListNode next;
        }
    }
}
