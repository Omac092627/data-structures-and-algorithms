﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Tree<T>
    {
        /// <summary>
        /// Create a property Node that holds the Root.
        /// </summary>
        public Node<T> Root { get; set; }

        /// <summary>
        /// Create an empty constructor of the class as to allow other methods to Instantiate it.
        /// </summary>
        public Tree()
        {

        }
        /// <summary>
        /// A constructor method to set the value to the root Node.
        /// You set Root = root as to not confuse the property of Root.
        /// </summary>
        /// <param name="value"></param>
        public Tree(T value)
        {
            Node<T> root = new Node<T>(value);

            Root = root;
        }


        /// <summary>
        /// This method arranges the Nodes in order from top to bottom
        /// It is a recursive method and calls the preorder method below
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<T> PreOrder(Node<T> root)
        {
            //conduct a preorder traversal
            //capture each of values in list
            //return that list

            List<T> traversal = new List<T>();
            PreOrder(traversal, root);


            return traversal;

        }

        /// <summary>
        /// This method returns the root.Value at the top of the Node List
        /// It is a recursive method assisting the above method
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        private void PreOrder(List<T> traversal, Node<T> root)
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
        public List<T> InOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            InOrder(traversal, root);

            return traversal;
        }

        /// <summary>
        /// This method is recursive and calls the root.Value in the middle. 
        /// Inorder methods refer to the midpoint.
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        public void InOrder(List<T> traversal, Node<T> root)
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

        public List<T> PostOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            PostOrder(traversal, root);

            return traversal;
        }

        /// <summary>
        /// This method post the root value at the end of the node stack
        /// The base class methods are there to prevent the stack overflow
        /// </summary>
        /// <param name="traversal"></param>
        /// <param name="root"></param>
        public void PostOrder(List<T> traversal, Node<T> root)
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

        public static int findMax(Node<int> root)
        {
            if (root == null)
            {
                return int.MinValue;
            }
            //Result//
            int res = root.Value;
            //Left result/Right result//
            int lres = findMax(root.LeftChild);
            int rres = findMax(root.RightChild);

            if (lres > res)
            {
                res = lres;
            }
            if (rres > res)
            {
                res = rres;
            }
            return res;
        }

    }
    }
