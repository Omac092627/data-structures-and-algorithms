using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace Fifo_Animal_Farm
{

    public class Shelter<T>
    {

        public Shelter(object value)
        {
            this.value = (Shelter<T>)value;
            Rear = Front;
        }


    public Shelter()
    {
    }

    private Shelter<T> value { get; set; }
    private Shelter<T> Front { get; set; }
    private Shelter<T> Rear { get; set; }
    private Shelter<T> Next { get; set; }
    private Shelter<T> Top { get; set; }

    public Shelter<string> Enqueue(string input, string input2)
    {
        input = "dog";
        input2 = "cats";

        Shelter<T> node = new Shelter<T>(input);
        Shelter<T> node2 = new Shelter<T>(input2);

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


    public Shelter<T> Dequeue()

    {
        if (!isEmpty())
        {
            Shelter<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        else
        {
            throw new Exception("Empty queue");
        }

    }

    public static implicit operator Node<T>(Shelter<T> v)
    {
        throw new NotImplementedException();
    }

    public void Push(Shelter<T> value)
    {
        Shelter<T> node = new Shelter<T>(value)
        {
            Next = Top
        };
        Top = node;
        //check if top is null first
    }


    public Shelter<T> Pop()
    {
        if (!isEmpty())
        {
            Shelter<T> temp = Top;
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

    public Shelter<T> Peek()
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
