using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Graph
{
    class AdjacencyMatrixGraph : GraphDS
    {

        int[,] adjacencyMatrix;
        public AdjacencyMatrixGraph(int numVertices,GraphType graphType):base(numVertices, graphType)
        {
            adjacencyMatrix = new int[numVertices, numVertices];
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    adjacencyMatrix[i, j] = 0;
                }
            }
        }
        public override void AddEdge(int v1, int v2)
        {
            if (v1 < 0 || v1 >= Numvertices || v2 < 0 || v2 > Numvertices)
                throw new Exception("vertex number is not valid");
            adjacencyMatrix[v1, v2] = 1;
            if (GraphType == GraphType.Undirected)
                adjacencyMatrix[v2, v1] = 1;
        }

        public override List<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v >= Numvertices )
                throw new Exception("vertex number is not valid");
            List<int> adjacentList = new List<int>();
            for (int i = 0; i < Numvertices; i++)
            {
                if(adjacencyMatrix[v,i]==1)
                {
                    adjacentList.Add(i);
                }
            }
            adjacentList.Sort();
            return adjacentList;
        }
        public override int GetIndegree(int vertex)
        {
            if (vertex < 0 || vertex >= Numvertices)
                throw new Exception("vertex number is not valid");
            int countIndegree = 0;
            for (int i = 0; i < Numvertices; i++)
            {
                if(adjacencyMatrix[i,vertex]==1)
                {
                    countIndegree++;
                }
            }
            return countIndegree;
        }
    }
}
