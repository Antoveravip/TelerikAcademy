/* Lesson 12 - Graphs and Graph Algorithms
 * Homework 1
 * 
 * Solve these problems from BGCoder:
 * 
 * Task 1.1: Algo Academy March 2012 – Problem 05 – Friends of Pesho
 * 
 * http://bgcoder.com/Contest/Practice/27
 * 
 */

namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;

    public class Friends
    {
        public static void Main()
        {
            // Read N - all points over a map, M - number of streets over a map and H - number of all hospitals 
            string[] data = Console.ReadLine().Split(' ');
            int allNodes = int.Parse(data[0]);
            int numberOfStreets = int.Parse(data[1]);
            int hospitals = int.Parse(data[2]);

            // Read all points that are hospitals over a map
            string[] hopitalsNodes = Console.ReadLine().Split(' ');

            // Data with all points over a map
            Dictionary<int, Node> allMapPoints = new Dictionary<int, Node>();

            // Data witl all points and all streets between them over a map
            Dictionary<Node, List<Connection>> map = new Dictionary<Node, List<Connection>>();

            for (int i = 0; i < numberOfStreets; i++)
            {
                // Read data with two points and distance between them
                string[] connection = Console.ReadLine().Split(' ');

                int onePoint = int.Parse(connection[0]);
                int anotherPoint = int.Parse(connection[1]);
                int distance = int.Parse(connection[2]);

                // Check if the readed point is not already in points data.
                if (!allMapPoints.ContainsKey(onePoint))
                {
                    // Create the point
                    Node firstPoint = new Node(onePoint);

                    // Adding the point in points data
                    allMapPoints.Add(onePoint, firstPoint);
                }

                // Check if the readed point is not already in points data.
                if (!allMapPoints.ContainsKey(anotherPoint))
                {
                    Node secondPoint = new Node(anotherPoint);
                    allMapPoints.Add(anotherPoint, secondPoint);
                }

                // Check if the readed point is not already in map data.
                if (!map.ContainsKey(allMapPoints[onePoint]))
                {
                    map.Add(allMapPoints[onePoint], new List<Connection>());
                }

                // Check if the readed point is not already in map data.
                if (!map.ContainsKey(allMapPoints[anotherPoint]))
                {
                    map.Add(allMapPoints[anotherPoint], new List<Connection>());
                }

                // Adding the readed two point and distance between them to map data
                map[allMapPoints[onePoint]].Add(new Connection(allMapPoints[anotherPoint], distance));
                map[allMapPoints[anotherPoint]].Add(new Connection(allMapPoints[onePoint], distance));
            }

            // Data with all hospitals
            List<int> allHospitals = new List<int>();

            for (int i = 0; i < hospitals; i++)
            {
                int someHospital = int.Parse(hopitalsNodes[i]);
                allHospitals.Add(someHospital);
                allMapPoints[someHospital].IsHospital = true;
            }

            long minDijkstra = long.MaxValue;

            for (int i = 0; i < allHospitals.Count; i++)
            {
                DijkstraAlgorithm(map, allMapPoints[allHospitals[i]]);

                long sum = 0;

                foreach (var point in allMapPoints)
                {
                    if (!point.Value.IsHospital)
                    {
                        sum += point.Value.DistanceByDijkstra;
                    }
                }

                if (sum < minDijkstra)
                {
                    minDijkstra = sum;
                }
            }

            Console.WriteLine(minDijkstra);
        }

        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var item in graph)
            {
                item.Key.DistanceByDijkstra = long.MaxValue;
            }

            queue.Enqueue(source);
            source.DistanceByDijkstra = 0;

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                foreach (var connection in graph[currentNode])
                {
                    var potDistance = connection.Distance + currentNode.DistanceByDijkstra;

                    if (potDistance < connection.ToNode.DistanceByDijkstra)
                    {
                        connection.ToNode.DistanceByDijkstra = potDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }   

        public class Node : IComparable
        {
            public Node(int id)
            {
                this.ID = id;
                this.IsHospital = false;
            }

            public int ID { get; private set; }

            public long DistanceByDijkstra { get; set; }

            public bool IsHospital { get; set; }

            public int CompareTo(object obj)
            {
                int compared = this.DistanceByDijkstra.CompareTo((obj as Node).DistanceByDijkstra);

                return compared;
            }
        }

        public class Connection
        {
            public Connection(Node node, long distance)
            {
                this.ToNode = node;
                this.Distance = distance;
            }

            public Node ToNode { get; set; }

            public long Distance { get; set; }
        }

        public class PriorityQueue<T> where T : IComparable
        {
            private T[] heap;
            private int index;

            public PriorityQueue()
            {
                this.heap = new T[16];
                this.index = 1;
            }

            public int Count
            {
                get
                {
                    return this.index - 1;
                }
            }

            public void Enqueue(T element)
            {
                if (this.index >= this.heap.Length - 1)
                {
                    this.IncreaseArray();
                }

                this.heap[this.index] = element;

                int childIndex = this.index;
                int parentIndex = childIndex / 2;
                this.index++;

                while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
                {
                    T swapValue = this.heap[parentIndex];
                    this.heap[parentIndex] = this.heap[childIndex];
                    this.heap[childIndex] = swapValue;

                    childIndex = parentIndex;
                    parentIndex = childIndex / 2;
                }
            }

            public T Dequeue()
            {
                T result = this.heap[1];

                this.heap[1] = this.heap[this.Count];
                this.index--;

                int rootIndex = 1;

                int minChild;

                while (true)
                {
                    int leftChildIndex = rootIndex * 2;
                    int rightChildIndex = leftChildIndex + 1;

                    if (leftChildIndex > this.index)
                    {
                        break;
                    }
                    else if (rightChildIndex > this.index)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                        {
                            minChild = leftChildIndex;
                        }
                        else
                        {
                            minChild = rightChildIndex;
                        }
                    }

                    if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                    {
                        T swapValue = this.heap[rootIndex];
                        this.heap[rootIndex] = this.heap[minChild];
                        this.heap[minChild] = swapValue;

                        rootIndex = minChild;
                    }
                    else
                    {
                        break;
                    }
                }

                return result;
            }

            public T Peek()
            {
                return this.heap[1];
            }

            private void IncreaseArray()
            {
                T[] copiedHeap = new T[this.heap.Length * 2];

                for (int i = 0; i < this.heap.Length; i++)
                {
                    copiedHeap[i] = this.heap[i];
                }

                this.heap = copiedHeap;
            }
        }
    }
}