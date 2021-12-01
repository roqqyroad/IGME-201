using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Queue
    {
        private LinkedList backingList;

        public Queue()
        {
            backingList = new LinkedList();
        }
        public void Enqueue(int newVal) { }

        public void Dequeue() { }

        public int Peek()
        {
            return 0;
        }
    }
}
