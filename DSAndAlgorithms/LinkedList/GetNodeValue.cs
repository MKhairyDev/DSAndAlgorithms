using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LinkedList
{
    /// <summary>
    /// 
    /// </summary>
   public class GetNodeValue
    {
        static int GetNodeHelper(SinglyLinkedListNode head, int positionFromTail, SinglyLinkedListNode node)
        {

            if (head == null)
                return 0;

            int count = 0;

            count += GetNodeHelper(head.next, positionFromTail, node) + 1;
            if (count - 1 == positionFromTail)
                node.Data = head.Data;
            return count;
        }
        static int GetNode(SinglyLinkedListNode head, int positionFromTail)
        {
            SinglyLinkedListNode newHead = new SinglyLinkedListNode(0, null);
            GetNodeHelper(head, positionFromTail, newHead);
            return newHead.Data;
        }
        public static void Run()
        {

            var node19 = new SinglyLinkedListNode(1, null);
            var node2 = new SinglyLinkedListNode(2, node19);
            var node6 = new SinglyLinkedListNode(3, node2);
            var nodeHead = new SinglyLinkedListNode(4, node6);
         
            var res = GetNode(nodeHead,2);
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
