using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace Fifo_Animal_Farm
{

    public class Animals<T>
    {

        public Animals(object value)
        {
            this.value = (Animals<T>)value;
            Rear = Front;
        }


    public Animals()
    {
    }

    private Animals<T> value { get; set; }
    private Animals<T> Front { get; set; }
    private Animals<T> Rear { get; set; }
    private Animals<T> Next { get; set; }
    private Animals<T> Top { get; set; }

    public Animals<string> Enqueue(string input, string input2)
    {
        input = "dog";
        input2 = "cats";

        Animals<T> node = new Animals<T>(input);
        Animals<T> node2 = new Animals<T>(input2);

        if (Front == null)
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


    public Animals<T> Dequeue()

    {
        if (!isEmpty())
        {
            Animals<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
        else
        {
            throw new Exception("Empty queue");
        }

    }

    public static implicit operator Node<T>(Animals<T> v)
    {
        throw new NotImplementedException();
    }

    public void Push(Animals<T> value)
    {
        Animals<T> node = new Animals<T>(value)
        {
            Next = Top
        };
        Top = node;
        //check if top is null first
    }


    public Animals<T> Pop()
    {
        if (!isEmpty())
        {
            Animals<T> temp = Top;
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

    public Animals<T> Peek()
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
