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
    public void Enqueue(T value)
    {
        Node newNode = new Node();
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
}
