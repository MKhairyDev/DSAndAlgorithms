
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    public class BinaryTreesAreTheSame
    {
        public static bool CheckIfTwoBinaryTreesAreTheSame(Node<int> node1, Node<int> node2)
        {
            //O(n) complexity
            if (node1 == null && node2 == null)
            {
                return true;
            }
            if (node1 == null)
            {
                return false;
            }
            if (node2 == null)
            {
                return false;
            }

            if (CheckIfTwoBinaryTreesAreTheSame(node1.GetLeft(), node2.GetLeft()) &&
                CheckIfTwoBinaryTreesAreTheSame(node1.GetRight(), node2.GetRight()))
            {
                return node1.value == node2.value;
            }
            return false;

        }
        public static void Run()
        {
            Node<int> subNode3Node1 = new Node<int>(3);
            subNode3Node1.AddChildren(new Node<int>(4), new Node<int>(5));
            Node<int> node1 = new Node<int>(1);
            node1.AddChildren(new Node<int>(2), subNode3Node1);
            Node<int> subNode3Node2 = new Node<int>(3);
            subNode3Node1.AddChildren(new Node<int>(4), new Node<int>(5));
            Node<int> node2 = new Node<int>(1);
            node2.AddChildren(new Node<int>(2), subNode3Node1);
            var res = CheckIfTwoBinaryTreesAreTheSame(node1, node2);
        }
    }
}
