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

    public class Connection : IComparable<Connection>
    {
        public Connection(int startHouse, int endHouse, int distance)
        {
            this.StartHouse = startHouse;
            this.EndHouse = endHouse;
            this.Distance = distance;
        }

        public int StartHouse { get; set; }

        public int EndHouse { get; set; }

        public int Distance { get; set; }

        public int CompareTo(Connection otherConnection)
        {
            int distanceDifference = this.Distance.CompareTo(otherConnection.Distance);

            if (distanceDifference == 0)
            {
                return this.StartHouse.CompareTo(otherConnection.StartHouse);
            }

            return distanceDifference;
        }

        public override string ToString()
        {
            string output = string.Format("From house {0} to house {1} -> distance = {2}", this.StartHouse, this.EndHouse, this.Distance);

            return output;
        }
    }
}
