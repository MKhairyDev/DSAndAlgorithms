using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
    /// <summary>
    /*
     Given a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only 1 right child.

Example 1:
Input: [5,3,6,2,4,null,8,1,null,null,null,7,9]

       5
      / \
    3    6
   / \    \
  2   4    8
 /        / \ 
1        7   9

Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]

 1
  \
   2
    \
     3
      \
       4
        \
         5
          \
           6
            \
             7
              \
               8
                \
                 9  
 

Constraints:

The number of nodes in the given tree will be between 1 and 100.
Each node will have a unique integer value from 0 to 1000.
     */
    /// </summary>
    public class IncreasingOrderSearchTree
    {
        /// <summary>
        /*
         *Complexity Analysis

Time Complexity: O(N), where NN is the number of nodes in the given tree.

Space Complexity: O(H) in additional space complexity, where HH is the height of the given tree, 
and the size of the implicit call stack in our in-order traversal.
         */
        /// </summary>
        static TreeNode currentNode;
        public static TreeNode IncreasingBST(TreeNode root)
        {
        var headNode=    new TreeNode(0, null, null);
            currentNode = headNode;
            InOrder(root);
            return headNode.right;
        }
        static void InOrder(TreeNode root)
        {
            if (root == null)
                return;

            InOrder(root.left);
            root.left = null;
            currentNode.right = root;
            currentNode = root;
            InOrder(root.right);

        }
        public static void Run()
        {
            TreeNode node27 = new TreeNode(7, null, null);
            TreeNode node21 = new TreeNode(9, null, null);
            TreeNode node18 = new TreeNode(8, node27, node21);

            TreeNode node11 = new TreeNode(1, null, null);
            TreeNode node15 = new TreeNode(2, node11, null);
            TreeNode node12 = new TreeNode(6, null, node18);
            TreeNode node13 = new TreeNode(3, node15, new TreeNode(4, null, null));
            TreeNode root1 = new TreeNode(5, node13, node12);

            var res=IncreasingBST(root1);
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
}
