using System;
using System.Collections.Generic;
using System.Text;

namespace ExamAppAverkin
{
    public class Graph
    {
        public static int n = 10; //колво вершин
        /*public bool[,] neighboursList ; //матрица смежности(наличие ребер)
        public double[,] weightMatrix; //матрица весов вершин графа
        int size = 10;
        public double[,] distances;



        //конструктор графа
        public Graph()
        {
            //neighboursList = new bool[size, size];
            weightMatrix = new double[size, size];
        }

        public void AddEdgeShuya()
        {

            neighboursList = new bool[10, 10] {
                { false, true, false, false, false, false, true, false, false, false },
                { true, false, true, false, false, false, true, false, false, false }, 
                { }, 
                { }, 
                { }, 
                { }, 
                { }, 
                { }, 
                { }, 
                { } 
            };

            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    neighboursList[]
                }
            }

            for (int i=0; i <n; i++)
            {
                for(int j= 0; j<n; j++)
                {
                    if (neighboursList[i, j] == false) continue;
                    Console.WriteLine($"Необходимо ввести расстояние {i + 1} | {j + 1} :");
                    double distances = Double.Parse(Console.ReadLine());
                    weightMatrix[i, j] = distances;
                    weightMatrix[j, i] = distances;
                }

            }
            
        }

        public double FinderPath(int start, int end)
        {
            Console.WriteLine();
            start = int.Parse(Console.ReadLine());
            end = int.Parse(Console.ReadLine());

            double[,] distance;
            distance.Floyd()
        }

        
        */
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
