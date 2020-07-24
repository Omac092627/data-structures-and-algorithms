using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateEmptyTree()
        {
            Tree<string> tree = new Tree<string>();

            Assert.Null(tree.Root);

        }

        [Fact]
        public void InstantiateTreeWithSingleRoot()
        {
            Tree<string> tree = new Tree<string>("Josie Cat");

            Assert.NotNull(tree.Root);
            Assert.Equal("Josie Cat", tree.Root.Value);
            Assert.IsType<Node<string>>(tree.Root);
            
        }

        [Fact]
        public void CanAddLeftAndRightToRoot()
        {
            Tree<char> tree = new Tree<char>('a');
            Node<char> leftChild = new Node<char>('b');
            Node<char> rightChild = new Node<char>('c');

            tree.Root.LeftChild = leftChild;
            tree.Root.RightChild = rightChild;

            Assert.NotNull(tree.Root.LeftChild);
            Assert.NotNull(tree.Root.RightChild);
            Assert.Equal('b', tree.Root.LeftChild.Value);
            Assert.Equal('c', tree.Root.RightChild.Value);
        }

        [Fact]
        public void CanReturnPreOrderTraverse()
        {
            //Arrange
            Tree<char> tree = new Tree<char>();


            Node<char> root = new Node<char>('a');

            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            List<char> order = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f', 'g'
            };

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            //Act

            //Assert
            List<char> preOrder = tree.PreOrder(tree.Root);
            Assert.Equal(order, preOrder);


        }

        [Fact]
        public void CanReturnInOrderTraverse()
        {
            //Arrange
            Tree<char> tree = new Tree<char>();


            Node<char> root = new Node<char>('a');

            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            List<char> order = new List<char>()
            {
                'd', 'b', 'e', 'a', 'f', 'c', 'g'
            };

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            //Act

            //Assert
            List<char> inOrder = tree.InOrder(tree.Root);
            Assert.Equal(order, inOrder);
        }

        [Fact]
        public void CanReturnPostOrderTraverse()
        {
            //Arrange
            Tree<char> tree = new Tree<char>();


            Node<char> root = new Node<char>('a');

            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            List<char> order = new List<char>()
            {
                'd', 'e', 'b', 'f', 'g', 'c', 'a'
            };

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            //Act

            //Assert
            List<char> postOrder = tree.PostOrder(tree.Root);
            Assert.Equal(order, postOrder);
        }


    }
}
