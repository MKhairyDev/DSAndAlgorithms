using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Invert a binary tree.

Example:

Input:

     4
   /   \
  2     7
 / \   / \
1   3 6   9
Output:

     4
   /   \
  7     2
 / \   / \
9   6 3   1
     */
    /// </summary>
    public class InvertBinaryTree
    {
        /// <summary>
        /*
         Since each node in the tree is visited only once, the time complexity is O(n)O(n), where nn is the number of nodes in the tree. We cannot do better than that, since at the very least we have to visit each node to invert it.

 Because of recursion, O(h)O(h) function calls will be placed on the stack in the worst case, where hh is the height of the tree. Because h\in O(n)h∈O(n), the space complexity is O(n)O(n).
         */
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var temp = InvertTree(root.left);
            root.left = InvertTree(root.right);
            root.right = temp;
            return root;
        }
        /// <summary>
        /*
         Since each node in the tree is visited / added to the queue only once, the time complexity is O(n)O(n), where nn is the number of nodes in the tree.

Space complexity is O(n)O(n), since in the worst case, the queue will contain all nodes in one level of the binary tree. For a full binary tree, the leaf level has \lceil \frac{n}{2}\rceil=O(n)⌈ 
2
n
​	
 ⌉=O(n) leaves.
         */
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTreeWithBreadthFirst(TreeNode root)
        {

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
           var currentNode=     queue.Dequeue();
                var temp = currentNode.left;
                currentNode.left = currentNode.right;
                currentNode.right = temp;
                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right)
;
            }
            return root;
        }
            public static void Run()
        {
            TreeNode node15 = new TreeNode(5, null, null);
            TreeNode node12 = new TreeNode(2, null, null);
            TreeNode node13 = new TreeNode(3, node15, null);
            TreeNode root1 = new TreeNode(1, node13, node12);
            var res = InvertTreeWithBreadthFirst(root1);
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
