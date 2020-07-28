using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Binary_Tree
{

    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}

