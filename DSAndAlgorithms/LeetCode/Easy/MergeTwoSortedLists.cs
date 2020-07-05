using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
   public class MergeTwoSortedLists
    {
        /*
         Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

Example:

Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
         */
        /**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) { val = x; }
* }
*/

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-1);
            ListNode head = dummy;
            while (l1!=null&&l2!=null)
            { 
                if(l1.val<=l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }
                dummy = dummy.next;
            }
            if(l1!=null)
            {
                dummy.next = l1;
            }
            else
            {
                dummy.next = l2;
            }
            return head.next;
        }
        public static void Run()
        {
            ListNode listOne1 = new ListNode(1);
            ListNode subListOne3 = new ListNode(3);
            ListNode subListOne5 = new ListNode(5);
            subListOne3.AddNextNode(subListOne5);
            listOne1.AddNextNode(subListOne3);
            ListNode listTwo1 = new ListNode(1);
            ListNode sublistTwo2 = new ListNode(2);
            ListNode sublistTwo4 = new ListNode(4);
            ListNode sublistTwo7 = new ListNode(7);
            
            sublistTwo2.AddNextNode(sublistTwo4);
            sublistTwo4.AddNextNode(sublistTwo7);
            listTwo1.AddNextNode(sublistTwo2);
            var res = MergeTwoLists(listOne1,listTwo1);
           // var res2 = MergeTwoLists();

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int value)
        {
            val = value;
        }
        public void AddNextNode(ListNode node)
        {
            next = node;
        }
    }
}
