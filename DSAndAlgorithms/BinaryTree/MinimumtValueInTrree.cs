
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    public class MinimumtValueInTrree: IExecute
    {
        public  int FindMinimumValue(Node<int> btNode)
        {
            if (btNode == null)
                return int.MinValue;
            if(btNode.GetLeft()==null)
            {
                return btNode.value;
            }

            return FindMinimumValue(btNode.GetLeft());

        }


        public void Run()
        {
            Node<int> subNode3Node1 = new Node<int>(4);
            Node<int> subNode2LeftNode1 = new Node<int>(2);
            subNode2LeftNode1.AddChildren(new Node<int>(1), null);
            Node<int> subNode2Node1 = new Node<int>(3);
            subNode2Node1.AddChildren(subNode2LeftNode1, subNode3Node1);
            Node<int> node1 = new Node<int>(5);
            node1.AddChildren(subNode2Node1, null);
            var res=FindMinimumValue(node1);

        }
    }
}
