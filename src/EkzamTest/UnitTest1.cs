using ExamAppAverkin;
using System;
using Xunit;

namespace EkzamTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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

            var result = 1.2;

            var start = "2";

            var end = "7";

            var (path, distance) = PathFinder.FindShortPath(graph, start, end);

            Assert.Equal(result, distance);
        }
    }
}
