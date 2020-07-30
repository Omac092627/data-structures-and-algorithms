using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node<int> Root { get; set; }


        public BinarySearchTree()
        {

        }

        /// <summary>
        /// A constructor method to set the value to the root Node.
        /// You set Root = root as to not confuse the property of Root.
        /// </summary>
        /// <param name="value"></param>
        public BinarySearchTree(int value)
        {
            Node<int> root = new Node<int>(value);

            Root = root;
        }




        /// <summary>
        /// This method arranges the Nodes in order from top to bottom
        /// It is a recursive method and calls the preorder method below
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<int> PreOrder(Node<int> root)
        {
            //conduct a preorder traversal
            //capture each of values in list
            //return that list

            List<int> traversal = new List<int>();
            PreOrder(traversal, root);


            return traversal;

        }

        /// <summary>
        /// This method returns the root.Value at the top of the Node List
        /// It is a recursive method assisting the above method
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        private void PreOrder(List<int> traversal, Node<int> root)
        {
            traversal.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(traversal, root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(traversal, root.RightChild);
            }

        }




        /// <summary>
        /// The inorder method starts at the middle node root
        /// The beginning method uses recursion InOrder to use the parameters below
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<int> InOrder(Node<int> root)
        {
            List<int> traversal = new List<int>();
            InOrder(traversal, root);

            return traversal;
        }

        /// <summary>
        /// This method is recursive and calls the root.Value in the middle. 
        /// Inorder methods refer to the midpoint.
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        public void InOrder(List<int> traversal, Node<int> root)
        {
            if (root.LeftChild != null)
            {
                InOrder(traversal, root.LeftChild);

            }
            traversal.Add(root.Value);

            if (root.RightChild != null)
            {
                InOrder(traversal, root.RightChild);
            }
        }


        /// <summary>
        /// This is a recursive method
        /// The first method refers to the root parameter
        /// It instantiates a new list
        /// PostOrder then calls the recursive method below but has different properties
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        public List<int> PostOrder(Node<int> root)
        {
            List<int> traversal = new List<int>();
            PostOrder(traversal, root);

            return traversal;
        }

        /// <summary>
        /// This method post the root value at the end of the node stack
        /// The base class methods are there to prevent the stack overflow
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        public void PostOrder(List<int> traversal, Node<int> root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(traversal, root.LeftChild);

            }

            if (root.RightChild != null)
            {
                PostOrder(traversal, root.RightChild);
            }
            traversal.Add(root.Value);
        }












        /// <summary>
        /// The main method for adding a number to the BST
        /// </summary>
        /// <param name="value">Takes an integer to build the node</param>
        public void Add(int value)
        {
            Root = Add(Root, value);
        }



        /// <summary>
        /// Helper method for the add method. 
        /// </summary>
        /// <param name="root">The current root node</param>
        /// <param name="value">Takes an integer to build the node</param>
        /// <returns>Returns the current root node</returns>
        public Node<int> Add(Node<int> root, int value)
        {
            if (root == null)
            {
                root = new Node<int>(value);
                return root;
            }

            if (value < root.Value)
            {
                root.LeftChild = Add(root.LeftChild, value);
            }
            else if (value > root.Value)
            {
                root.RightChild = Add(root.RightChild, value);
            }
            return root;
        }


        /// <summary>
        /// Define a method named contains that accepts a value, 
        /// and returns a boolean indicating whether or not 
        /// the value is in the tree at least once.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Contains(Root, value);
            }
        }

        /// <summary>
        /// The logic for implementing the contains method.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(Node<int> root, int value)
        {
            bool answer = false;

            if (value < root.Value)
            {
                if (root.LeftChild != null)

                    answer = Contains(root.LeftChild, value);
            }
            else if (value > root.Value)
            {
                if (root.RightChild != null)
                    answer = Contains(root.RightChild, value);
            }
            else if (root.Value == value)
            {
                answer = true;
            }
            return answer;
        }

    }
}

