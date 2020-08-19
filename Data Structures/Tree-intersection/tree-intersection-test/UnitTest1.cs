using System;
using Xunit;
using Tree_intersection;
using System.Collections.Generic;

namespace tree_intersection_test
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnInOrderTraverse()
        {
            //Arrange
            Stack<Node<int>> tree = new Stack<Node<int>>();


            Stack<Node<int>> root = new Stack<Node<int>>('a');

            Stack<Node<int>> b = new Stack<Node<int>>('b');
            Stack<Node<int>> c = new Stack<Node<int>>('c');
            Stack<Node<int>> d = new Stack<Node<int>>('d');
            Stack<Node<int>> e = new Stack<Node<int>>('e');
            Stack<Node<int>> f = new Stack<Node<int>>('f');
            Stack<Node<int>> g = new Stack<Node<int>>('g');

            List<char> order = new List<char>()
            {
                'd', 'b', 'e', 'a', 'f', 'c', 'g'
            };

        }

    }
}
