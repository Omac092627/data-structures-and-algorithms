using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{

    public class Stack<T>
    {
        private Node<T> Top { get; set; }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
            //check if top is null first
        }

        public T Peek()
        {
            if(isEmpty())
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                return Top.Value;
            }
        }


        public bool isEmpty()
        {

            if(Top == null)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        public Node<T> Pop()
        {
            if(!isEmpty())
            {
                Node<T> temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp;
            }
            else
            {
                throw new Exception("The stack is empty");
            }
        }


    }

}
