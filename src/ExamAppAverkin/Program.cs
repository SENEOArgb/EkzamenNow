using System;

namespace ExamAppAverkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var graph = new Graph();

            graph.AddNode("1", "2", 0.94);
            graph.AddNode("1", "7", 1.88);
            graph.AddNode("2", "3", 0.66);
            graph.AddNode("2", "7", 1.2);
            graph.AddNode("3", "4", 1.04);
            graph.AddNode("3", "6", 1.7);
            graph.AddNode("4", "6", 0.77);
            graph.AddNode("5", "6", 1.92);
            graph.AddNode("6", "10", 1.52);
            graph.AddNode("7", "8", 0.53);
            graph.AddNode("8", "9", 1.54);
            graph.AddNode("9", "10", 0.86);

            Console.WriteLine("Введите начальную точку для построения маршрута (от 1 до 10):");
            var start = Console.ReadLine();

            Console.WriteLine("Введите конечную точку для построения маршрута (от 1 до 10):");
            var end = Console.ReadLine();

            var (path, distance) = PathFinder.FindShortPath(graph, start, end);

            Console.WriteLine($"Кратчайший путь: {string.Join("->", path)}");
            Console.WriteLine($"Расстояние: {distance}");
        }
    }
}
