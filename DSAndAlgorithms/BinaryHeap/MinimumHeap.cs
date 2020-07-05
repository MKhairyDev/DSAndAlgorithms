using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryHeap
{
   public class MinimumHeap<T>:Heap<T> where T:IComparable<T>
    {
        public MinimumHeap():base()
        {

        }
        public MinimumHeap(int size):base(size)
        {

        }



        public override void SiftDown(int index)
        {

            var leftIndex = GetLeftChildIndex(index);
            var rightIndex = GetRightChildIndex(index);

            int smallerIndex=-1;
            if (leftIndex!=-1&&rightIndex!=-1)
            {
                smallerIndex = GetElementAtIndex(leftIndex).CompareTo(GetElementAtIndex(rightIndex)) < 0 ? leftIndex : rightIndex;
            }
           else if(leftIndex!=-1)
            {
                smallerIndex = leftIndex;
            }
            else if(rightIndex!=-1)
            {
                smallerIndex = rightIndex;
            }

            if(smallerIndex==-1)

            {
                return;
            }

          if(  GetElementAtIndex(smallerIndex).CompareTo(GetElementAtIndex(index))<0)
            {
                Swap(smallerIndex, index);
                SiftDown(smallerIndex);
            }

        }

        public override void SiftUp(int index)
        {
            int parentIndex = GetParentIndex(index);
            if (parentIndex == -1)
                return;
            if(GetElementAtIndex(parentIndex).CompareTo(GetElementAtIndex(index))>0)
            {
                Swap(parentIndex, index);
                SiftUp(parentIndex);
            }

        }
    }
}
