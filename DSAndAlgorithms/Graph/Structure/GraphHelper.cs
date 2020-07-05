using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Graph.Structure
{
    public class GraphHelper
    {
        /*for unconnected graph, we should iterate through all 
        nodes and start DFT on each node to make sure that all nodes have been visited 
        for(int 1=0; i<n;i++)
        {
        DepthFirstTraversal(graph, vistedList, adjacent);
        }
        */
        public virtual void DepthFirstTraversal(GraphDS graph, int[] vistedList, int currentVertex)
        {

            if (vistedList[currentVertex] == 1)
                return;
            vistedList[currentVertex] = 1;
            var adjacentList = graph.GetAdjacentVertices(currentVertex);
            foreach (var adjacent in adjacentList)
            {
                DepthFirstTraversal(graph, vistedList, adjacent);
            }

            Console.WriteLine(currentVertex);

        }

        /*for unconnected graph, we should iterate through all 
         * nodes and start DFT on each node to make sure that all nodes have been visited 
         * for(int 1=0; i<n;i++)
         * {
         * BreadthFirstTraversal(graph, vistedList, adjacent);
         * }
         */
        public virtual void BreadthFirstTraversal(GraphDS graph, int[] vistedList, int currentVertex)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(currentVertex);
            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                if (vistedList[vertex] == 1)
                {
                    continue;
                }
                Console.WriteLine(vertex);
                vistedList[vertex] = 1;
                var adjacentList = graph.GetAdjacentVertices(vertex);
                foreach (var adjacent in adjacentList)
                {
                    if (vistedList[vertex] != 1)
                    {
                        queue.Enqueue(adjacent);
                    }

                }


            }
        }
        public List<int> TopologicalSort(GraphDS graph)
        {
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> indegreeMap = new Dictionary<int, int>();
            List<int> sortedList = new List<int>();
            for (int i = 0; i < graph.Numvertices; i++)
            {
             var indegreeNum=   graph.GetIndegree(i);
                indegreeMap.Add(i, indegreeNum);
                if (indegreeNum == 0)
                    queue.Enqueue(i);
            }
            while(queue.Count>0)
            {
                var currentVertex=queue.Dequeue();
                sortedList.Add(currentVertex);
            var adjacentList=    graph.GetAdjacentVertices(currentVertex);
                for (int i = 0; i < adjacentList.Count; i++)
                {
               var updatedIndegree =    graph.GetIndegree(i) - 1;
                    indegreeMap[i] = updatedIndegree;
                    if(updatedIndegree==0)
                    {
                        queue.Enqueue(i);
                    }

                }
            }
            if (sortedList.Count != graph.Numvertices)
                throw new Exception("The graph had a cycle");
            return sortedList;
        }
    }
}
