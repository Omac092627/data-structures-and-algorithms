using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Binary_Tree
{

    public class Node<T>
    {
        public int data;
        public Node<int> left, right;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}

