using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LinkedList
{
    class Compare_Two_linked_lists
    {
        static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
           
            if (head1 == null && head2 == null)
                return true;
            if (head1 != null && head2 != null)
            {
               
          
                return head1.Data == head2.Data&& CompareLists(head1.next, head2.next);
            }
            return false;
        }

        public static void Run()
        {

            var node19 = new SinglyLinkedListNode(4, null);
            var node2 = new SinglyLinkedListNode(3, node19);
            var node6 = new SinglyLinkedListNode(2, node2);
            var nodeHead = new SinglyLinkedListNode(1, node6);

            var node29 = new SinglyLinkedListNode(4, null);
            var node22 = new SinglyLinkedListNode(3, node29);
            var node26 = new SinglyLinkedListNode(2, node22);
            var nodeHead2 = new SinglyLinkedListNode(1, node26);

            var res = CompareLists(nodeHead, nodeHead2);
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
