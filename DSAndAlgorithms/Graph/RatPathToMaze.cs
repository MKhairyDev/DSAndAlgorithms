using DSAndAlgorithms.Graph;
using System.Collections.Generic;

namespace DSAndAlgorithms.Recusion
{
    class RatPathToMaze:IExecute
    {

        public static bool FindRatPathToMaze(GraphNode currentCell, List<GraphNode> currentPath)
        {
            //Complexity deponds on the numbers of neighbors each cell has, it's not a simple number
            //currentPath.Add(currentCell);
            //if (currentCell.IsEnd())
            //{
            //    return true;
            //}
            //foreach (var neighborCell in currentCell.GetAdjacencyList())
            //{
            //    if(!currentPath.Contains(neighborCell))
            //    {
            //        List<GraphNode> neighborPath = new List<GraphNode>(currentPath);
            //      if(  FindRatPathToMaze(neighborCell, neighborPath))
            //        {
            //            currentPath.Clear();
            //            currentPath.AddRange(neighborPath);
            //            return true;
            //        }
            //    }
            //}
            return false;
        }

        public static List<GraphNode>CreateMazePath()
        {
            GraphNode cell1 = new GraphNode(1);
            GraphNode cell2 = new GraphNode(2);
            GraphNode cell3 = new GraphNode(3);
            GraphNode cell4 = new GraphNode(4);
            GraphNode cell5 = new GraphNode(5);
            GraphNode cell6 = new GraphNode(6);
            GraphNode cell7 = new GraphNode(7);
            GraphNode cell8 = new GraphNode(8);
            GraphNode cell9 = new GraphNode(9);
            cell1.AddEdge(2);
            cell2.AddEdge(3);
            cell2.AddEdge(1);
            cell3.AddEdge(8);
            cell3.AddEdge(4);
            cell8.AddEdge(3);
            cell4.AddEdge(3);
            cell4.AddEdge(7);
            cell4.AddEdge(5);
            cell5.AddEdge(4);
            cell5.AddEdge(6);
            cell6.AddEdge(5);
            cell6.AddEdge(7);
            cell6.AddEdge(9);
            cell9.AddEdge(6);
            cell9.SetEnd(true);
            return new List<GraphNode> { cell1, cell2, cell3, cell4, cell5, cell6, cell7, cell8, cell9 };
        }

        public void Run()
        {
            var maze = CreateMazePath();
            List<GraphNode> path = new List<GraphNode>();

            bool result = FindRatPathToMaze(maze[0], path);
        }
    }
}
