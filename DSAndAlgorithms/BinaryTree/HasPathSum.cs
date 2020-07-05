using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
  public class HasPathSum
    {
        public static bool CheckHasPathSum(Node<int>root,int sum)
        {
            if(root==null)
            {
                return sum==0;
            }
        
            int subSum = sum - root.value;
            if (subSum == 0)
                return true;
            return CheckHasPathSum(root.GetLeft(), subSum) || CheckHasPathSum(root.GetRight(), subSum);
            
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
            Node<int> subNode2LeftNode2 = new Node<int>(3);
            subNode2LeftNode2.AddChildren(new Node<int>(1), new Node<int>(2));
            subNode1LeftNode1.AddChildren(subNode2LeftNode2, null);
            node1.AddChildren(subNode1LeftNode1, subNode2Node1);
            var res = CheckHasPathSum(node1, 33);

        }
    }
}
