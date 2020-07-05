using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     Input: head = [1,0,1]
Output: 5
Explanation: (101) in base 2 = (5) in base 10
Example 2:

Input: head = [0]
Output: 0
Example 3:

Input: head = [1]
Output: 1
Example 4:

Input: head = [1,0,0,1,0,0,1,1,1,0,0,0,0,0,0]
Output: 18880
Example 5:

Input: head = [0,0]
Output: 0
     */
    /// </summary>
    public class ConvertBinaryNumberInLinkedListToIntegerProblem
    {

        public static int GetDecimalValue(ListNode head)
        {
            // Initialized result  
            int res = 0;
            while(head!=null)
            {
                res = (res << 1) + (head.val);
                head = head.next;
            }
          
            return res;
        }
        public static void Run()
        {
    
            ListNode linkedList3 = new ListNode(1);
            ListNode linkedList2 = new ListNode(0, linkedList3);
            ListNode linkedList1 = new ListNode(1,linkedList2);
            var res = GetDecimalValue(linkedList1);
            var res2 = GetDecimalValue(new ListNode(0));
            var res3 = GetDecimalValue(new ListNode(0, new ListNode(0)));
            var res4 = GetDecimalValue(new ListNode(1));


            ListNode linkedList = new ListNode(1,
                new ListNode(0,new ListNode(0,
                new ListNode(1,new ListNode(0,new ListNode(0,
                new ListNode(1,new ListNode(1,new ListNode(1,
                new ListNode(0,new ListNode(0,new ListNode(0,
                new ListNode(0,new ListNode(0,new ListNode(0)))))))))))))));
            var res5=GetDecimalValue(linkedList);
        }

        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
