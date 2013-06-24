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
    using System.Collections.Generic;

    public class Node<T>
    {
        public Node()
        {
            this.Children = new List<Node<T>>();
        }
        
        public Node(T value) : this()
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }
    }
}
