using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Graph
{
    public class AdjacencySetGraph : GraphDS
    {
        List<GraphNode> graphNodes=new List<GraphNode>();
        public AdjacencySetGraph(int numVertices, GraphType graphType) : base(numVertices, graphType)
        {

            for (int i = 0; i < numVertices; i++)
            {
                graphNodes.Add(new GraphNode(i));
            }
        }
        public override void AddEdge(int v1, int v2)
        {
            if (v1 < 0 || v1 >= Numvertices || v2 < 0 || v2 > Numvertices)
                throw new Exception("vertex number is not valid");
            graphNodes[v1].AddEdge(v2);
        }

        public override List<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v >= Numvertices)
                throw new Exception("vertex number is not valid");
            return graphNodes[v].GetAdjacencyList();
        }
        public override int GetIndegree(int vertex)
        {
            if (vertex < 0 || vertex >= Numvertices)
                throw new Exception("vertex number is not valid");
            int countIndegree = 0;
            for (int i = 0; i < Numvertices; i++)
            {
                if (GetAdjacentVertices(i).Contains(vertex))
                {
                    countIndegree++;
                }
            }
            return countIndegree;
        }
    }
}
