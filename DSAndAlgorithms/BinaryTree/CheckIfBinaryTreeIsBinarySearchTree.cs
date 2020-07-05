using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
   public class CheckIfBinaryTreeIsBinarySearchTree
    {
        public static bool CheckTree(Node<int>root,int min,int max)
        {
            if (root == null)
                return true;

            if (root.value < min || root.value > max)
                return false;
            return CheckTree(root.GetLeft(), min, root.value) && CheckTree(root.GetRight(), root.value, max);
               
        }
        public static void Run()
        {
            Node<int> subNode3Node1 = new Node<int>(9);
            Node<int> subNode2LeftNode1 = new Node<int>(6);
            subNode3Node1.AddChildren(null, new Node<int>(11));
            Node<int> subNode2Node1 = new Node<int>(7);
            subNode2Node1.AddChildren(subNode2LeftNode1, subNode3Node1);
            Node<int> node1 = new Node<int>(5);
            Node<int> subNode1LeftNode1 = new Node<int>(4);
            Node<int> subNode2LeftNode2 = new Node<int>(2);
            subNode2LeftNode2.AddChildren(new Node<int>(1), null);
            subNode1LeftNode1.AddChildren(subNode2LeftNode2, null);
            node1.AddChildren(subNode1LeftNode1, subNode2Node1);
         var res=   CheckTree(node1, 1, 11);

        }
    }
}
