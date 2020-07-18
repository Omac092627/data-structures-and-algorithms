using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<T>
    {
        private Node<T> Front { get; set; }
        private Node<T> Rear { get; set; }
        //front = null    rear = front//
        public Queue()
        {
            Rear = Front;

        }

        /// <summary>
        /// Inherit value for node and insert it in the last position of queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            //create new node
            Node<T> node = new Node<T>(value);


            if(Front == null)
            {
                Front = node;
                Rear = node;

            }
            else
            {

            Rear.Next = node;
            Rear = node;
            }
        }

        /// <summary>
        /// Call is empty, if false return front value
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (Front == null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Peek if stack is empty
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (isEmpty())
            {
                throw new Exception("queue stack empty");
            }
            else
            {
                return Front.Value;
            }
        }

        /// <summary>
        /// Method to dequeue value from node stack
        /// </summary>
        /// <returns></returns>
        public Node<T> Dequeue()
        {
            if(!isEmpty())
            {
                Node<T> temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else
            {
                throw new Exception("Empty queue");
            }
        }

   

    }
}
