
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    /// <summary>
    /*
     Given a binary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Note: A leaf is a node with no children.

Example:

Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its depth = 3.
     */
    /// </summary>
    public class MaximumDepthInTrree 
    {
        public static int FindMaxDepth(Node<int> btNode)
        {
            if (btNode == null)
                return 0;
            if(btNode.GetLeft() == null && btNode.GetRight()==null)
            {
               return 1;
            }
            int rightMaxDepth = 0;
            int leftMaxDepth = 0;
            leftMaxDepth += FindMaxDepth(btNode.GetLeft()) + 1;
            rightMaxDepth += FindMaxDepth(btNode.GetRight())+1;
            return Math.Max(leftMaxDepth,rightMaxDepth);
        
        
        }


        public static void Run()
        {
            Node<int> subNode3Node1 = new Node<int>(7);
            Node<int> subNode2LeftNode1 = new Node<int>(15);
           // subNode3Node1.AddChildren( null, new Node<int>(11));
            Node<int> subNode2Node1 = new Node<int>(20);
            subNode2Node1.AddChildren(subNode2LeftNode1, subNode3Node1);
            Node<int> node1 = new Node<int>(3);
            Node<int> subNode1LeftNode1 = new Node<int>(9);
            Node<int> subNode2LeftNode2 = new Node<int>(2);
           // subNode2LeftNode2.AddChildren(new Node<int>(1), null);
            //subNode1LeftNode1.AddChildren(subNode2LeftNode2, null);
            node1.AddChildren(subNode1LeftNode1, subNode2Node1);
            var res= FindMaxDepth(node1);

        }
    }
}
