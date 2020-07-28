using System;
using Xunit;
using Find_Maximum_Binary_Tree;

namespace FindMaximumBinary
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxTrees()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(2);
            tree.root.left = new Node(7);
            tree.root.right = new Node(5);
            tree.root.left.right = new Node(6);
            tree.root.left.right.left = new Node(1);
            tree.root.left.right.right = new Node(11);
            tree.root.right.right = new Node(9);
            tree.root.right.right.left = new Node(4);

            Console.WriteLine("Maximum element is " + BinaryTree.findMax(tree.root));
        }
    }
}
