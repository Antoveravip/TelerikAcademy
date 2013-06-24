namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinarySearchTreeTest
    {
        static void Main()
        {
            BinarySearchTree<int, string> firstTree = new BinarySearchTree<int, string>();
            firstTree.Add(6, "6");
            firstTree.Add(18, "18");
            firstTree.Add(3, "3");
            firstTree.Add(1, "1");
            firstTree.Add(8, "8");

            foreach (var node in firstTree)
            {
                Console.WriteLine(node.Key + " " + node.Value);
            }
            Console.WriteLine();

            firstTree.Remove(3);
            BinarySearchTree<int, string> secondTree = (BinarySearchTree<int, string>)firstTree.Clone();

            Console.WriteLine(firstTree);
            Console.WriteLine(secondTree);

            BinarySearchTree<int, string> thirdTree = new BinarySearchTree<int, string>();
            thirdTree.Add(5, "12");
            Console.WriteLine(thirdTree);

            Console.WriteLine(firstTree.Equals(secondTree));
            Console.WriteLine(object.ReferenceEquals(firstTree, secondTree));
            Console.WriteLine(firstTree.Equals(thirdTree));
            Console.WriteLine(object.ReferenceEquals(firstTree, thirdTree));

            thirdTree.Add(4, "12");
            thirdTree.Add(2, "2");
            thirdTree.Add(18, "22");
            thirdTree.Add(4, "6");
            Console.WriteLine(thirdTree);

            Console.WriteLine(firstTree.Equals(thirdTree));
            Console.WriteLine(object.ReferenceEquals(firstTree, thirdTree));


            BinarySearchTree<int, string> fourthTree = new BinarySearchTree<int, string>();
            fourthTree.Add(2, "1");
            fourthTree.Add(2, "one");
            Console.WriteLine(fourthTree);
        }
    }
}