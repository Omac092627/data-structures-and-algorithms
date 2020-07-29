using System;
using Xunit;
using  Find_Maximum_Binary_Tree;


namespace FindMaximumBinary
{
    public class FindMaximumInTreeTests
    {
        [Fact]
        public void CanReturnTheHighestIntInTheTree()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> two = new Node<int>(2);
            Node<int> three = new Node<int>(3);
            Node<int> four = new Node<int>(4);
            Node<int> five = new Node<int>(5);
            Node<int> six = new Node<int>(6);
            Node<int> seven = new Node<int>(7);

            tree.root = root;

            root.left = two;
            root.right = three;

            two.left = four;
            two.right = five;

            three.left = six;
            three.right = seven;

            int expected = 7;
            // Act
            int returnFromMethod = BinaryTree<int>.findMax(root);

            // Assert
            Assert.Equal(expected, returnFromMethod);
        }
    }
}
