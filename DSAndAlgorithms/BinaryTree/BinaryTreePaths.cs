using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
    /// <summary>
    /*
     Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
     */
    /// </summary>
    public class BinaryTreePathsProblem
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            string path = "";
            List<string> listPath = new List<string>();
            BinaryTreePathsRec(root, listPath, path);
            return listPath;
        }
        private static void BinaryTreePathsRec(TreeNode node, List<string> listStr, string path)
        {
            if (node == null)
            {
                return;
            }
            path += node.val.ToString();
            if (node.left == null && node.right == null)
            {
                listStr.Add(path);
                path = "";
                return;
            }
            path += "->";
            BinaryTreePathsRec(node.left, listStr, path);
            BinaryTreePathsRec(node.right, listStr, path);

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

            var res2 = BinaryTreePaths(node13);
            var res = BinaryTreePaths(root1);
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
