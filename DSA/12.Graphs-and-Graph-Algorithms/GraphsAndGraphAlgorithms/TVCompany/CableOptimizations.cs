/* Lesson 12 - Graphs and Graph Algorithms
 * Homework 2
 * 
 * You are given a cable TV company. The company needs to lay cable to 
 * a new neighborhood (for every house). If it is constrained to bury the
 * cable only along certain paths, then there would be a graph representing 
 * which points are connected by those paths. But the cost of some of the 
 * paths is more expensive because they are longer. If every house is a node 
 * and every path from house to house is an edge, find a way to minimize the 
 * cost for cables. 
 */
namespace TVCompany
{
    using System;
    using System.Collections.Generic;

    public class CableOptimizations
    {
        public static void Main()
        {
            Console.WriteLine("A cable TV company needs to lay cables to a new neighborhood (for every house).");
            Console.WriteLine("Some of the paths are longer.\nThis program find a way to minimize the cost for cables.\n");

            // Because there may be a houses that is near, but not part of the neighbourhood, 
            // I choose to do calculation according the Kruskal algorithm.

            // This is number of all houses in the neighborhood
            int housesNumber = 10;

            // For console input - TODO before release - checks for incorrect input
            // int houses = int.Parse(Console.ReadLine());

            // Here I keep all connections in the neighborhood
            List<Connection> connections = new List<Connection>();

            // Creating the map of the connection between each house in the neighborhood
            InitializeNeighborhoodMap(connections);

            // Sortinth the connections
            connections.Sort();

            // To start from 1, not from 0 adding 1 to houses number ...
            int[] houses = new int[housesNumber + 1];

            // ... and start checking from 1
            int housesCount = 1;

            List<Connection> mapForCables = new List<Connection>();

            housesCount = FindMinimumSpanningTree(connections, houses, mapForCables, housesCount);

            PrintMinimumSpanningTree(mapForCables);
        }

        private static int FindMinimumSpanningTree(List<Connection> connections, int[] houses, List<Connection> map, int housesCount)
        {
            foreach (var connection in connections)
            {
                // Check if this house is not visited
                if (houses[connection.StartHouse] == 0)
                {
                    // Check and if the house of the other side is not visited
                    if (houses[connection.EndHouse] == 0)
                    {
                        houses[connection.StartHouse] = houses[connection.EndHouse] = housesCount;
                        housesCount++;
                    }
                    else
                    {
                        houses[connection.StartHouse] = houses[connection.EndHouse];
                    }

                    map.Add(connection);
                }
                else
                {
                    if (houses[connection.EndHouse] == 0)
                    {
                        houses[connection.EndHouse] = houses[connection.StartHouse];
                        map.Add(connection);
                    }
                    else if (houses[connection.EndHouse] != houses[connection.StartHouse])
                    {
                        int oldTreeNumber = houses[connection.EndHouse];

                        for (int i = 0; i < houses.Length; i++)
                        {
                            if (houses[i] == oldTreeNumber)
                            {
                                houses[i] = houses[connection.StartHouse];
                            }
                        }

                        map.Add(connection);
                    }
                }
            }

            return housesCount;
        }

        private static void PrintMinimumSpanningTree(List<Connection> usedConnection)
        {
            int distance = 0;

            // 42 because this is the meaning of life! :)
            Console.WriteLine(new string('-', 42)); 
            foreach (var connection in usedConnection)
            {
                Console.WriteLine(connection);
                distance += connection.Distance;
            }

            Console.WriteLine(new string('-', 42)); 
            Console.WriteLine("Total distance to be wired {0}", distance);
            Console.WriteLine(new string('-', 42)); 
        }

        private static void InitializeNeighborhoodMap(List<Connection> connections)
        {
            // TODO - before release - manual or from file input of connections!
            connections.Add(new Connection(1, 3, 7));
            connections.Add(new Connection(1, 2, 6));
            connections.Add(new Connection(1, 4, 11));
            connections.Add(new Connection(2, 4, 4));
            connections.Add(new Connection(3, 4, 22));
            connections.Add(new Connection(3, 5, 9));
            connections.Add(new Connection(4, 5, 10));
            connections.Add(new Connection(5, 6, 14));
            connections.Add(new Connection(6, 7, 15));
            connections.Add(new Connection(6, 8, 20));
            connections.Add(new Connection(7, 8, 6));
            connections.Add(new Connection(7, 9, 16));
            connections.Add(new Connection(8, 9, 10));
            connections.Add(new Connection(8, 1, 35));
            connections.Add(new Connection(7, 2, 28));
            connections.Add(new Connection(9, 10, 8));
            connections.Add(new Connection(8, 10, 14));
        }
    }
}