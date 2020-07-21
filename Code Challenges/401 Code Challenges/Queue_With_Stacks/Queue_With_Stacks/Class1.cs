using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;


namespace Queue_With_Stacks
{
    public class PseudoQueue<T>
    {
        public PseudoQueue(object value)
        {
            this.value = (PseudoQueue<T>)value;
            Rear = Front;

        }

        public PseudoQueue()
        {
        }

        private PseudoQueue<T> value { get; set; }
        private PseudoQueue<T> Front { get; set; }
        private PseudoQueue<T> Rear { get;  set; }
        private PseudoQueue<T> Next { get;  set; }
        private PseudoQueue<T> Top { get; set; }

        public PseudoQueue<int[]> Enqueue(int[] input, int[] input2)
        {
             input = new int[4] {5, 0, 0, 0};
             input2 = new int[4]{ 10, 15, 20, 0};

            PseudoQueue<T> node = new PseudoQueue<T>(input);
            PseudoQueue<T> node2 = new PseudoQueue<T>(input2);
            
            if(Front == null)
            {
                Front = node;
                Rear = node2;
                Front.Push(Rear);
            }
            else
            {
                Rear.Next = value;
                Rear = value;
            }

            return Enqueue(input, input2);
            
        }


        public PseudoQueue<T> Dequeue() 
        
        {
            if (!isEmpty())
            {
                PseudoQueue<T> temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else
            {
                throw new Exception("Empty queue");
            }

        }

        public static implicit operator Node<T>(PseudoQueue<T> v)
        {
            throw new NotImplementedException();
        }

        public void Push(PseudoQueue<T> value)
        {
            PseudoQueue<T> node = new PseudoQueue<T>(value)
            {
                Next = Top
            };
            Top = node;
            //check if top is null first
        }


        public PseudoQueue<T> Pop()
        {
            if (!isEmpty())
            {
                PseudoQueue<T> temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp;
            }
            else
            {
                throw new Exception("The stack is empty");
            }
        }

        public bool isEmpty()
        {

            if (Top == null)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        public PseudoQueue<T> Peek()
        {
            if (isEmpty())
            {
                throw new Exception("queue stack empty");
            }
            else
            {
                return Front.value;
            }
        }
    }

}
