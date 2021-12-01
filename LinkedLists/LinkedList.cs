using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class LinkedList
    {
        // Some ideas we discussed in class:
        // set at an index
        //      this[3] = 4 ???
        // add(value)
        // insertAt
        // removeAt
        private Node head;
        private Node last;

        public LinkedList() { }

        public void Add(int newNumber)
        {
            // 2 -> 3 -> 4 -> empty 
            // 1 -> 2 -> 3 -> 4 -> empty
            if (head == null)
            {
                this.head = new Node.Cons(newNumber, new Node.Empty());
                this.last = head;
            }
            else
            {
                this.head = new Node.Cons(newNumber, head);
            }
        }

        public void InsertAt(int index, int newValue)
        {
            //3 -> 2 -> 1 -> empty
            // InsertAt(1, 7)
            // 3 -> 7 -> 2 -> 1 -> empty

            // keep going to next value
            // for each, decrease index
            // when index is 0, insert value

            if (index == 0)
            {
                this.Add(newValue);
                return;
            }

            Node.Cons previous = null;
            Node current = head;

            while (!(current is Node.Empty))
            {
                Node.Cons consCurrent = (Node.Cons)current;

                if (index == 0)
                {
                    // insert value
                    // change current to new node whose next is the current
                    Node newNode = new Node.Cons(newValue, current);

                    previous.Next = newNode;

                    return;
                }

                index = index - 1;
                previous = consCurrent;
                current = consCurrent.Next;
            }

            // If we got here, then we got all the way through the list
            // without finding the right index, so the index was bigger
            // than the list is long.
            throw new IndexOutOfRangeException();
        }

        public override string ToString()
        {
            // 1 -> 2 -> 3
            if (head == null)
            {
                return "empty";
            }

            // go through each of the nodes, and print the next
            string returnString = "";

            Node current = head;
            while (!(current is Node.Empty))
            {
                Node.Cons consCurrent = (Node.Cons)current;

                returnString += consCurrent.Data.ToString();
                returnString += " -> ";

                current = consCurrent.Next;
            }

            returnString += "empty";

            return returnString;
        }

        /*
         * Please implement the following four methods.
         */

        //public int FindIndexOf(int value) { }
        //public void AddToEnd(int newValue) { }
        //public void DeleteAt(int index) { }
        //public void UpdateAt(int index, int newValue) { }


        public abstract class Node
        {
            public Node Add(int newNumber)
            {
                return new Cons(newNumber, this);
            }

            public class Empty : Node { }

            public class Cons : Node
            {
                public int Data;
                public Node Next;

                public Cons(int data, Node next)
                {
                    Data = data;
                    Next = next;
                }
            }
        }
    }
}
