using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    public class RangeSumOfBST
    {
        static int sum = 0;
        public static int RangeSumBST(TreeNode root, int L, int R)
        {

            DFS(root,L,R);
            return sum;
        }
        private static void DFS(TreeNode root, int l, int r)
        {
            if (root == null)
            return;

                if (l <= root.val && root.val <= r)
                {
                    sum += root.val;
                }
                if (l < root.val)
                    DFS(root.left, l, r);
                 if (r > root.val)
                    DFS(root.right, l, r);
            
        }
        public static void Run()
        {
            TreeNode subNode1LeftNode1 = new TreeNode(5, new TreeNode(3,new TreeNode(1)), new TreeNode(7,new TreeNode(6)));
            TreeNode subNode2LeftNode2 = new TreeNode(2);
            TreeNode subNode2Node1 = new TreeNode(15, new TreeNode(13), new TreeNode(18));
            TreeNode node1 = new TreeNode(10, subNode1LeftNode1, subNode2Node1);


        var res=    RangeSumBST(node1,6,10);

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
