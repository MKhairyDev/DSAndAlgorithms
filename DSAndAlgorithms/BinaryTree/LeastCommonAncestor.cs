using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
   public class LeastCommonAncestor
    {
        public static Node<int>FindAncestor(Node<int>root,Node<int>node1,Node<int>node2)
        {
            if (root == null)
                return null;
            if(root==node1||root==node2)
            {
                return root;
            }
          var lca=  FindAncestor(root.GetLeft(), node1, node2);
           var rca= FindAncestor(root.GetRight(), node1, node2);
            if(lca!=null&&rca!=null)
            {
                return root;
            }
            if (lca != null)
                return lca;
            return rca;
        }
        public static void Run()
        {
            Node<int> node9 = new Node<int>(9);
            Node<int> node6 = new Node<int>(6);
            Node<int> node11 = new Node<int>(11);
            node9.AddChildren(null, node11);
            Node<int> node7 = new Node<int>(7);
            node7.AddChildren(node6, node9);
            Node<int> mainRoot = new Node<int>(5);
            Node<int> node4 = new Node<int>(4);
            Node<int> node3 = new Node<int>(3);
            node3.AddChildren(new Node<int>(1), new Node<int>(2));
            node4.AddChildren(node3, null);
            mainRoot.AddChildren(node4, node7);
            var res = FindAncestor(mainRoot, node11, node6);

        }
    }
}
