using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_intersection
{
    public class insertion_Tree<T>
    {


        public Node<T> Root { get; set; }
        /// <summary>
        /// create new node
        /// </summary>
        /// <param name="ele"></param>
        /// <returns></returns>
        public static Node<T> newNode(int ele)
        {

            Node<T> temp = new Node<T>();
            temp.key = ele;
            temp.left = null;
            temp.right = null;
            return temp;
        }

        /// <summary>
        /// Function two print common elements in given two trees  
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        public static void TreeIntersection(Node<T> root1, Node<T> root2)
        {
            Stack<Node<T>> s1 = new Stack<Node<T>>();
            Stack<Node<T>> s2 = new Stack<Node<T>>();

            while (true)
            {
                // push the Nodes of first tree in stack s1  
                if (root1 != null)
                {
                    s1.Push(root1);
                    root1 = root1.left;
                }

                // push the Nodes of second tree in stack s2  
                else if (root2 != null)
                {
                    s2.Push(root2);
                    root2 = root2.left;
                }

                // Both root1 and root2 are NULL here  
                else if (s1.Count > 0 && s2.Count > 0)
                {
                    root1 = s1.Peek();
                    root2 = s2.Peek();

                    // If current keys in two trees are same  
                    if (root1.key == root2.key)
                    {
                        s1.Pop();
                        s2.Pop();

                        // move to the inorder successor  
                        root1 = root1.right;
                        root2 = root2.right;
                    }

                    else if (root1.key < root2.key)
                    {
                        // If Node of first tree is smaller, than that of  
                        // second tree, then its obvious that the inorder  
                        // successors of current Node can have same value  
                        // as that of the second tree Node. Thus, we pop  
                        // from s2  
                        s1.Pop();
                        root1 = root1.right;

                        // root2 is set to NULL, because we need  
                        // new Nodes of tree 1  
                        root2 = null;
                    }
                    else if (root1.key > root2.key)
                    {
                        s2.Pop();
                        root2 = root2.right;
                        root1 = null;
                    }
                }

                // Both roots and both stacks are empty  
                else
                {
                    break;
                }
            }
        }
        /// <summary>
        /// A utility function to do inorder traversal  
        /// </summary>
        /// <param name="root"></param>
        public static void inorder(Node<T> root)
        {
            if (root != null)
            {
                inorder(root.left);
                inorder(root.right);
            }
        }

        /// <summary>
        /// A utility function to insert a new Node with given key in BST 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Node<T> insert(Node<T> node, int key)
        {
            /* If the tree is empty, return a new Node */
            if (node == null)
            {
                return newNode(key);
            }

            /* Otherwise, recur down the tree */
            if (key < node.key)
            {
                node.left = insert(node.left, key);
            }
            else if (key > node.key)
            {
                node.right = insert(node.right, key);
            }

            /* return the (unchanged) Node pointer */
            return node;
        }

    }
}
