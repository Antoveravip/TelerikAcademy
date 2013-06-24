/* Lesson 4 - Trees and Traversals
 * Homework 1
 * 
 * You are given a tree of N nodes represented as a set of N-1 pairs 
 * of nodes (parent node, child node), each in the range (0..N-1).
 * 
 * Write a program to read the tree and find:
 * a) the root node
 * b) all leaf nodes
 * c) all middle nodes
 * d) the longest path in the tree
 * e)* all paths in the tree with given sum S of their nodes
 * f)* all subtrees with given sum S of their nodes
 */

namespace WorkWithTrees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tree
    {
        private static int n;
        private static Node<int>[] nodes;

        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            nodes = new Node<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                string connection = Console.ReadLine();
                var nodeParts = connection.Split(' ');

                int parrentID = int.Parse(nodeParts[0]);
                int childID = int.Parse(nodeParts[1]);

                nodes[parrentID].Children.Add(nodes[childID]);
                nodes[childID].HasParent = true;
            }

            Console.WriteLine("Solutions for task:");

            // Task a) find the root node
            Console.WriteLine("Find the root node!");
            var root = FindRoot(nodes);
            Console.WriteLine("The root of this tree is: {0}", root.Value);

            // Task b) find all leaf nodes
            Console.WriteLine("Find all leaf nodes!");
            var leafs = FindAllLeaf(nodes);
            if (leafs.Count != 0)
            {
                Console.Write("The leafs are:");
                foreach (var leaf in leafs)
                {
                    Console.Write(" {0},", leaf.Value);
                }

                Console.Write('\b' + " " + '\n');
            }
            else if (leafs.Count == 1)
            {
                Console.WriteLine("There is only one leaf: {0}, ", leafs[0].Value);
            }
            else
            {
                Console.WriteLine("This tree has no leafs!");
            }

            // Task c) find all middle nodes
            Console.WriteLine("Find all middle nodes!");
            var middleNodes = FindAllMiddleNodes(nodes);
            if (middleNodes.Count != 0)
            {
                Console.Write("The middle nodes are:");
                foreach (var node in middleNodes)
                {
                    Console.Write(" {0},", node.Value);
                }

                Console.Write('\b' + " " + '\n');
            }
            else if (middleNodes.Count == 1)
            {
                Console.WriteLine("There is only one middle node: {0}, ", middleNodes[0].Value);
            }
            else
            {
                Console.WriteLine("This tree has no middle node!");
            }

            // Task d) find the longest path in the tree / height /
            Console.WriteLine("Find the longest path in the tree / height /");
            var longestPath = FindLongestPath(root);
            Console.WriteLine("Longest path is: {0}", longestPath);           
        }
        
        public static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParrent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParrent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParrent.Length; i++)
            {
                if (!hasParrent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "This tree has no root");
        }

        public static List<Node<int>> FindAllLeaf(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        public static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        public static int FindLongestPath(Node<int> root)
        {
            int longestPath = 0;
            if (root.Children.Count == 0)
            {
                longestPath = 0;
            }

            foreach (var node in root.Children)
            {
                int currentPath = FindLongestPath(node);
                longestPath = Math.Max(longestPath, currentPath);
            }

            return longestPath + 1;
        }
    }
}