using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.

You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.

Example 1:

Input: 
	Tree 1                     Tree 2                  
          1                         2                             
         / \                       / \                            
        3   2                     1   3                        
       /                           \   \                      
      5                             4   7                  
Output: 
Merged tree:
	     3
	    / \
	   4   5
	  / \   \ 
	 5   4   7
 

Note: The merging process must start from the root nodes of both trees.
     */
    /// </summary>
    public class MergeTwoBinaryTrees
    {
   
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode mergedTree = new TreeNode(0, null, null);
            if (t1 == null && t2 == null)
                return null;
            if (t1 != null && t2 != null)
            {
                var sum = t1.val + t2.val;
                mergedTree.val = sum;
            }
            else if(t1 != null)
            {
                mergedTree = t1;
            }
            else if (t2 != null)
            {
                mergedTree = t2;
            }
            mergedTree.left =   MergeTrees(t1?.left, t2?.left);
            mergedTree.right = MergeTrees(t1?.right, t2?.right);

            return mergedTree;
        }
        public static void Run()
        {
            TreeNode node15 = new TreeNode(5,null,null);
            TreeNode node12 = new TreeNode(2, null, null);
            TreeNode node13 = new TreeNode(3,node15,null);
            TreeNode root1 = new TreeNode(1, node13, node12);

            TreeNode node24 = new TreeNode(4, null, null);
            TreeNode node27= new TreeNode(7, null, null);
            TreeNode node21 = new TreeNode(1, null, node24);
            TreeNode node23 = new TreeNode(3, null, node27);
            TreeNode root2 = new TreeNode(2, node21, node23);
           var res= MergeTrees(root1, root2);
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
