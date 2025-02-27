using System;

namespace DataStructures
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList
    {
        Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var temp = head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
            }
        }
        public void Print()
        {
            Node current = head;

            if (current != null)
                Console.WriteLine(current.Data);

            while (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine(current.Data);
            }
        }
        public bool Remove(int data)
        {
            if (head == null) return false;

            if (head.Data == data)
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public Node Find(int data)
        {

            Node current = head;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;

        }
    }

}