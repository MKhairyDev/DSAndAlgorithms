using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryTree
{
   public class UniqueTreeStructureNumber
    {
        public static int CountTrees(int numNodes)
        {
            if(numNodes<=1)
            {
                return 1;
            }
            int sum = 0;
            for (int i = 1; i < numNodes; i++)
            {
                int countLeftTrees = CountTrees(i - 1);
                int countRightTrees = CountTrees(numNodes - i);
                sum = sum + (countLeftTrees * countRightTrees);
            }
            return sum;
        }


        public static void Run()
        {

         var res = CountTrees(3);

        }
    }
}
