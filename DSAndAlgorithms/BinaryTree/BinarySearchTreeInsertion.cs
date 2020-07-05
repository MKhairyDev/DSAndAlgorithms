using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
   public class BinarySearchTreeInsertion
    {
        /// <summary>
        /*
         You are given a pointer to the root of a binary search tree and values to be inserted into the tree. Insert the values into their appropriate position in the binary search tree and return the root of the updated binary tree. You just have to complete the function.

Input Format

You are given a function,

Node * insert (Node * root ,int data) {

}
Constraints

No. of nodes in the tree  500
Output Format

Return the root of the binary search tree after inserting the value into the tree.

Sample Input

        4
       / \
      2   7
     / \
    1   3
The value to be inserted is 6.

Sample Output

         4
       /   \
      2     7
     / \   /
    1   3 6
         */
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Node insert(Node root, int data)
        {

            if (root == null)
            {
                Node newNode = new Node(data);
                //newNode.data=data;
                return newNode;
            }
            Node head = root;

            if (data > root.Data)
                root.Right = insert(root.Right, data);
            else
            {
                root.Right = insert(root.Left, data);
            }
            return root;
        }
        public class Node
        {
            public Node(int val)
            {
                Data = val;

            }
            public void AddChildren( Node left, Node right)
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
          var res= insert(node1,13);
        }
    }
}
