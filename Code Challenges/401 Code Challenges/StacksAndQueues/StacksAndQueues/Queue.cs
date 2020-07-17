using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        private Node Rear { get; set; }
        //front = null    rear = front//
        public Queue()
        {
            Rear = Front;

        }

        public void Enqueue(string value)
        {
            //create new node
            Node node = new Node(value);


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

    }
}
