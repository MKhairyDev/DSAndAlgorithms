using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LinkedList
{
    /// <summary>
    /// Url:https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    /// https://www.geeksforgeeks.org/merge-two-sorted-linked-lists/
    /// </summary>
    class MergeTwoSortedLinkedLists
    {
        static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            SinglyLinkedListNode mergedList = new SinglyLinkedListNode(0,null);
            var tail = mergedList;
            while (head1 != null && head2 != null)
            {
                if (head1.Data <= head2.Data)
                {
                    tail.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    tail.next = head2;
                    head2 = head2.next;
                }
                tail = tail.next;
            }
                if (head1 != null)
                {
                tail.next = head1;
                }
                else if (head2 != null)
                {
                tail.next = head2;
                }


            
            return mergedList.next;
        }

        public static void Run()
        {

            var node19 = new SinglyLinkedListNode(7, null);
            var node2 = new SinglyLinkedListNode(5, node19);
            var node6 = new SinglyLinkedListNode(2, node2);
            var nodeHead = new SinglyLinkedListNode(1, node6);

            var node29 = new SinglyLinkedListNode(10, null);
            var node22 = new SinglyLinkedListNode(9, node29);
            var node26 = new SinglyLinkedListNode(4, node22);
            var nodeHead2 = new SinglyLinkedListNode(3, node26);

            var res = MergeLists(nodeHead, nodeHead2);
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
