using System;
using Find_Maximum_Binary_Tree;

namespace Find_Maximum_Binary_Tree
{

    public class BinaryTree
    {
        public Node root;

    public static void Main(string[] args)
    {
    }
        /// <summary>
        ///  Returns the max value in a binary tree 
        ///  If the node is null then return the minimum value
        ///  If the leftchild is greater than reult than the result is equal to leftchild
        ///  If the rightchild is greater than result, than the result is equal to the right child
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int findMax(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }
            //Result//
            int res = node.data;
            //Left result/Right result//
            int lres = findMax(node.left);
            int rres = findMax(node.right);

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
