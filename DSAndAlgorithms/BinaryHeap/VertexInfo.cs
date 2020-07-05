using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BinaryHeap
{
    public class VertexInfo : IComparable<VertexInfo>
    {
        int _distance;
        int _LastVertex;
        public VertexInfo(int distance,int lastVertex)
        {
            _distance = distance;
            _LastVertex = lastVertex;
        }
       public int GetlastVertex()
        {
            return _LastVertex;
        }
        public int getDistance()
        {
            return _distance;
        }
        public int CompareTo(VertexInfo other)
        {
            if (other == null)
                return 1;

            return _distance.CompareTo(other._distance);
        }
    }
}
