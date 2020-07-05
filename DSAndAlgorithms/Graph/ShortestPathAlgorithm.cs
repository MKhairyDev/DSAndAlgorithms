using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAndAlgorithms.Graph
{
   public class ShortestPathAlgorithm
    {
        public  List<int> ShortestPath(GraphDS graph, int source,int destination)
        {
            Dictionary<int, DistanceInfo> distanceMap = BuildDistanceTable(graph, source);
            Stack<int> shortestPathStack = new Stack<int>();
            shortestPathStack.Push(destination);
         var lastVertex=   distanceMap[destination].GetLastVertex();
            while(lastVertex!=-1&& lastVertex!=source)
            {
                shortestPathStack.Push(lastVertex);
                lastVertex = distanceMap[lastVertex].GetLastVertex();
            }
            if(lastVertex==-1)
            {
                return null;
            }
            return shortestPathStack.ToList();
        }
        public Dictionary<int,DistanceInfo>BuildDistanceTable(GraphDS graph, int source)
        {
            Dictionary<int, DistanceInfo> distanceMap = new Dictionary<int, DistanceInfo>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            for (int i = 0; i < graph.Numvertices; i++)
            {
                distanceMap.Add(i, new DistanceInfo());
            }
            distanceMap[0].SetDisance(0);
            distanceMap[0].SetLastVertex(source);
            while (queue.Count>0)
            {

                var vertex=queue.Dequeue();
                var adjacentList=graph.GetAdjacentVertices(vertex);
              var distanceInfo= distanceMap[vertex];
                foreach (var adjacent in adjacentList)
                {
                    var currentDistance = distanceMap[adjacent].GetDistance();
                    if (currentDistance == -1)
                    {
                        distanceMap[adjacent].SetDisance(distanceInfo.GetDistance() + 1);
                        distanceMap[adjacent].SetDisance(distanceInfo.GetLastVertex());
                        if (graph.GetAdjacentVertices(adjacent).Count > 0)
                        {
                            queue.Enqueue(vertex);
                        }
                    }
                }

            }
            return distanceMap;
        }
    }
}
