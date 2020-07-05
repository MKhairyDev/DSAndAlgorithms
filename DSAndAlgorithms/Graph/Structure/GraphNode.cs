using System.Collections.Generic;

namespace DSAndAlgorithms.Graph
{
    public class GraphNode
    {
        int _id;
        bool _isEnd;
        HashSet<int> _neighborList;
        public GraphNode(int id)
        {
            _id = id;
            _neighborList = new HashSet<int>();
        }
        public void AddEdge(int adjacent)
        {
            _neighborList.Add(adjacent);
        }
        public List<int> GetAdjacencyList()
        {
            List<int> sortedList = new List<int>(_neighborList);
            sortedList.Sort();
            return sortedList;
        }
        public void SetEnd(bool isEnd)
        {
            _isEnd = isEnd;
        }
        public bool IsEnd()
        {
            return _isEnd;
        }
    }
}
