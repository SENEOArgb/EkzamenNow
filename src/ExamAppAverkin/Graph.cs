using System;
using System.Collections.Generic;
using System.Text;

namespace ExamAppAverkin
{
    public class Graph
    {
        public static int n = 10; //колво вершин
        //метод нахождения кратчайшего пути
        private static double[,] Floyd(double[,] a)
        {
            double[,] d = new double[n, n];
            d = (double[,])a.Clone();
            for (int i = 1; i <= n; i++)
                for (int j = 0; j <= n - 1; j++)
                    for (int k = 0; k <= n - 1; k++)
                        if (d[j, k] > d[j, i - 1] + d[i - 1, k])
                            d[j, k] = d[j, i - 1] + d[i - 1, k];
            return d;
        }


        private readonly Dictionary<string, Dictionary<string, double>> _adjacencyList;

        public Graph()
        {
            _adjacencyList = new Dictionary<string, Dictionary<string, double>>();
        }

        public void AddNode(string from, string to, double weight)
        {
            if (!_adjacencyList.ContainsKey(from))
                _adjacencyList[from] = new Dictionary<string, double>();

            _adjacencyList[from][to] = weight;

            if (!_adjacencyList.ContainsKey(to))
                _adjacencyList[to] = new Dictionary<string, double>();
        }

        public Dictionary<string, double> GetNeighbors(string node)
        {
            return _adjacencyList.ContainsKey(node) ? _adjacencyList[node] : new Dictionary<string, double>();
        }

        public IEnumerable<string> Nodes => _adjacencyList.Keys;
    }
}
