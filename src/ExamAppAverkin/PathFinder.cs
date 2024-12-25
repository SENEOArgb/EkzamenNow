using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamAppAverkin
{
    public class PathFinder
    {
        public static (List<string> path, double distance) FindShortPath(Graph graph, string start, string end)
        {
            var distances = new Dictionary<string, double>();
            var previousNodes = new Dictionary<string, string>();
            var unvisited = new HashSet<string>(graph.Nodes);

            foreach(var node in graph.Nodes)
            {
                distances[node] = int.MaxValue;
            }

            distances[start] = 0;

            while (unvisited.Count > 0)
            {
                var current = unvisited.OrderBy(n => distances[n]).First();
                unvisited.Remove(current);

                if (current == end) break;

                foreach ( var (neighbor, weight) in graph.GetNeighbors(current)){
                    if (!unvisited.Contains(neighbor)) continue;

                    var promezhDistance = distances[current] + weight;
                    if (promezhDistance < distances[neighbor])
                    {
                        distances[neighbor] = promezhDistance;
                        previousNodes[neighbor] = current;
                    }
                }
            }

            var path = new List<string>();
            var currentPathNode = end;

            while (previousNodes.ContainsKey(currentPathNode))
            {
                path.Add(currentPathNode);
                currentPathNode = previousNodes[currentPathNode];
            }

            path.Add(start);
            path.Reverse();

            return (path, distances[end]);
        } 
    }
}
