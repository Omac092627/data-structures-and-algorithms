using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{

    public class Stack
    {
        public Node Top { get; set; }

        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            //check if top is null first
        }

        public string Peek()
        {
            if(isEmpty())
            {
                throw new Exception("Empty stack");
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

        public Node Pop()
        {
            if(!isEmpty())
            {
                Node temp = Top;
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
