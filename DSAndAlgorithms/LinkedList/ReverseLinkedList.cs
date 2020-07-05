using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LinkedList
{
    /// <summary>
    /// URL:https://www.hackerrank.com/challenges/reverse-a-linked-list/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    /// </summary>
    class ReverseLinkedList
    {
        static SinglyLinkedListNode reverse(SinglyLinkedListNode head)
        {
            if (head == null|| head.next == null)
                return head;
            var rest = reverse(head.next);
            head.next.next = head;
            head.next = null;
            return rest;
        }
        static SinglyLinkedListNode reverseRec(SinglyLinkedListNode node)
        {
            SinglyLinkedListNode head = null;
            while (node != null)
            {
                SinglyLinkedListNode n = new SinglyLinkedListNode(node.Data, null); // Clone
                n.next = head;
                head = n;
                node = node.next;
            }
            return head;

        }
        public static void Run()
        {

            var node19 = new SinglyLinkedListNode(4, null);
            var node2 = new SinglyLinkedListNode(3, node19);
            var node6 = new SinglyLinkedListNode(2, node2);
            var nodeHead = new SinglyLinkedListNode(1, node6);

            var res = reverse(nodeHead);
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
