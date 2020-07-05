using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryHeap
{
    public abstract class Heap<T> where T : IComparable<T>
    {
        private static int max_Size = 40;
        private T[] array;
        private int count = 0;
        int index;
        public Heap():this(max_Size)
        {
            
        }
        public Heap(int size)
        {
            array = (T[])Array.CreateInstance(typeof(T), size);
        }
        public void Heapify(int endIndex)
        {
            int index = GetParentIndex(endIndex);
            while(index>=0)
            {
                SiftDown(index);
                index--;
            }
        }
        public abstract void SiftDown(int index);
        public abstract void SiftUp(int index);
        public  void Insert(T item)
        {
            if (IsFull())
                throw new Exception("is full");
            array[count] = item;
            SiftUp(count);
            count++;

        }

        public T Remove()
        {
            var min = GetHighestPriority();
            array[0] = array[count-1];
            count--;
            SiftDown(0);
            return min;
        }
        public int GetLeftChildIndex(int index)
        {
            int leftChildIndex = 2 * index + 1;
            if (leftChildIndex >= count)
                return -1;
            return leftChildIndex;
        }
        public int GetRightChildIndex(int index)
        {
            int rightChildIndex = 2 * index + 2;
            if (rightChildIndex >= count)
                return -1;
            return rightChildIndex;
        }
        public int GetParentIndex(int index)
        {
            int rightChildIndex = 2 * index + 2;
            if (index<0 || index> count)
                return -1;
            return (index-1)/2;
        }
        protected void Swap(int index1,int index2)
        {
           var temp= array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public int GetCount()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        
        public bool IsFull()
        {
            return count == array.Length;
        }

        public T GetElementAtIndex(int index)
        {
           return array[index];
        }
        public T GetHighestPriority()
        {
            if(IsEmpty())
                throw new Exception("is empty");
            return array[0];
        }
    }
    
}
