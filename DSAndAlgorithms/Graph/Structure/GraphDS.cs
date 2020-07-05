using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Graph
{
    public abstract class GraphDS
    {
        public GraphDS(int numVertices, GraphType graphType)
        {
            Numvertices = numVertices;
            GraphType = graphType;
        }
        public GraphType GraphType { get; }
        public int Numvertices { get; }
        public abstract void AddEdge(int v1, int v2);
        public abstract int GetIndegree(int vertex);

        public abstract List<int> GetAdjacentVertices(int v);
    }
    public enum GraphType
    {
        Directed,
        Undirected
    }
}
