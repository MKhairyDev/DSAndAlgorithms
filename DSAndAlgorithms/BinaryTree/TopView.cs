using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
    /// <summary>
    /*
     You are given a pointer to the root of a binary tree. Print the top view of the binary tree. You only have to complete the function.

For example :

     3
   /   \
  5     2
 / \   / \
1   4 6   7
 \       /
  9     8
Top View : 1 -> 5 -> 3 -> 2 -> 7
     */
    /// </summary>
    public class TopViewProblem
    {
        public static void TopView(Node root)
        {
//                  if(root.left==null&&root.right==null)
//      {
//          System.out.print(root.data);
//          return;
//      }

//      Node head=root;
//      int count=0;
//      Queue<Node> q=new LinkedList<Node>();
//      q.add(root);
//      while(q.size()>0)
//      {
//Node delItem=q.remove();
//count++;
//System.out.print(delItem.data);
//System.out.print(" ");
//if(root.left!=null&&(delItem.data<=head.data||count==1))
//{
//q.add(root.left);
//}
//if(root.right!=null&&(delItem.data>head.data||count==1))
//{
//q.add(root.right);
//}

//root=q.peek();
            //PostOrder(root);
            //PreOrder(root.Right);
        }

        private static void PostOrder(Node root)
        {
            if (root == null)
                return;

            PostOrder(root.Left);
            Console.Write(root.Data);
            Console.Write(" ");
        }
        private static void PreOrder(Node root)
        {
            if (root == null)
                return;
            Console.Write(root.Data);
            Console.Write(" ");
            PreOrder(root.Right);

        }

        public class Node
        {
            public Node(int val)
            {
                Data = val;

            }
            public void AddChildren(Node right, Node left)
            {
                Left = left;
                Right = right;
            }
            public int Data;
            public Node Left;
            public Node Right;
        }
    public static void Run()
        {
        Node subNode3Node1 = new Node(9);
        Node subNode2LeftNode1 = new Node(6);
        subNode3Node1.AddChildren(null, new Node(11));
        Node subNode2Node1 = new Node(7);
        subNode2Node1.AddChildren(subNode2LeftNode1, subNode3Node1);
        Node node1 = new Node(5);
        Node subNode1LeftNode1 = new Node(4);
        Node subNode2LeftNode2 = new Node(3);
        subNode2LeftNode2.AddChildren(new Node(1), new Node(2));
        subNode1LeftNode1.AddChildren(subNode2LeftNode2, null);
        node1.AddChildren(subNode1LeftNode1, subNode2Node1);
       TopView(node1);
        }
    }
}
