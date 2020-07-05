using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Medium
{
    /// <summary>
    /*
     Given a binary tree, return the inorder traversal of its nodes' values.

Example:

Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [1,3,2]
Follow up: Recursive solution is trivial, could you do it iteratively?
     */
    /// </summary>
    public class BinaryTreeInorderTraversal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> inorderList = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode head = root;
            while (head != null || stack.Count>0)
            {
                while (head != null)
                {
                    stack.Push(head);
                    head = head.left;
                }
                head = stack.Pop();
                inorderList.Add(head.val);
                head = head.right;

            }
            return inorderList;


            //InorderTraversalRec(root,inorderList);
            //return inorderList;
        }
        private static void InorderTraversalRec(TreeNode root, List<int> inorderList)
        {
     

            if (root == null)
                return;

            InorderTraversalRec(root.left,inorderList);
                inorderList.Add(root.val);
            InorderTraversalRec(root.right, inorderList);

        }
        public static void Run()
        {
            var res = InorderTraversal(new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null)));
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
