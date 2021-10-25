using System;

///<summary>generic class</summary>
public class Queue<T>
{
    ///<summary>returns the type of the object passed in</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>node class for list</summary>
    public class Node
    {
        ///<summary>value in node</summary>
        public T value = default(T);
        ///<summary>pointer to next node</summary>
        public Node next = null;

        ///<summary>node constructor</summary>
        public void constuctNode(T val)
        {
            value = val;
        }
    }

    ///<summary>head of queue list</summary>
    public Node head;
    ///<summary>tail of queue list</summary>
    public Node tail;
    ///<summary>number of queue list nodes</summary>
    public int count = 0;

    ///<summary>adds node to queue</summary>
    public void Enqueue(T val)
    {
        Node newNode = new Node();
        newNode.value = val;
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count += 1;
    }

    ///<summary>returns number of nodes</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>adds node to queue</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T result = head.value;
        head = head.next;
        count -= 1;
        return result;
    }
}
