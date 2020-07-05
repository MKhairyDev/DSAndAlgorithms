using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
   public class PrintAllPaths
    {
        public static void PrintAllPathsFromRootToleaf(Node<int>root )
        {
            //using array is much effecient as i will override the values in each path
            Node<int>[] Path = new Node<int>[1000];
            PathTreeRec(root, Path,0);

        }
        private static void PathTreeRec(Node<int>currentNode, Node<int>[] path,int printLength)
        {
     
            if (currentNode == null)
                return;
            path[printLength]=currentNode;
            printLength ++;

            if (currentNode.GetLeft() == null && currentNode.GetRight() == null)
            {
                PrintPath(path, printLength);

            }
            else
            {
                PathTreeRec(currentNode.GetLeft(), path, printLength);

                PathTreeRec(currentNode.GetRight(), path, printLength);
            }
        }
        private static void PrintPath(Node<int>[] path, int printLength)
        {
            for (int i = 0; i < printLength; i++)
            {
                Console.Write(path[i].value);
               
            }
            Console.Write(Environment.NewLine);
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
           PrintAllPathsFromRootToleaf(node1);

        }
    }
}
