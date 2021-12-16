using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    // Three stacks was easier to visualize but not so much implement i guess.
    // I feel like it also worked different in my head than here.. 
    class Program
    {
        
        static void Main(string[] args)
        {
            //queue
            Queue StackedQueue = new Queue();
            //queue's stacks assigned
            StackedQueue.stackOne = new Stack<int>();
            StackedQueue.stackTwo = new Stack<int>();

            //enqueue stuff
            QSENQUEUE(StackedQueue, 10);
            QSENQUEUE(StackedQueue, 9);
            QSENQUEUE(StackedQueue, 8);
            QSENQUEUE(StackedQueue, 7);
            QSENQUEUE(StackedQueue, 6);
            QSENQUEUE(StackedQueue, 5);
            QSENQUEUE(StackedQueue, 4);
            QSENQUEUE(StackedQueue, 3);
            QSENQUEUE(StackedQueue, 2);
            QSENQUEUE(StackedQueue, 1);

            //dequeue stuff
           
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);
            QSDEQUEUE(StackedQueue);

            /*
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            Console.WriteLine(QSDEQUEUE(StackedQueue));
            */
        }

        //Queue has three stacks of ints to put stuff in
        public class Queue
        {
            public Stack<int> stackOne;
            public Stack<int> stackTwo;
            public Stack<int> stackThree;
        }

        //when dequeueing look at the queue im not sure if this method would really work for even two stacks even after trying to look into nullpointer issues... ?
        static int QSDEQUEUE(Queue StackedQueue)
        {
            //make a value to kill
            int deadVal;
            //if there are no items in either stacks get mad
            //
            //
            //
            // ALL EMPTY STACKS
            //
            //
            //
            if (StackedQueue.stackOne.Count() == 0 && StackedQueue.stackTwo.Count == 0 && StackedQueue.stackThree.Count == 0)
            {
                Console.WriteLine("You cannot dequeue from an empty queue. Please fix this issue and come back. You caused an error...");
            }

            //OR if stack two is empty, look in stack one to dequeue and go
            //
            //
            //
            // IF STACKS TWO AND THREE ARE EMPTY
            //
            //
            //
            else if (StackedQueue.stackTwo.Count == 0 && StackedQueue.stackThree.Count == 0)
            {
                //put all of stack two into stack three
                while (StackedQueue.stackTwo.Count != 0)
                {
                    //put all of stack one into stack two
                    while (StackedQueue.stackOne.Count != 0)
                    {
                        deadVal = QSPOP(StackedQueue.stackOne);
                        QSPUSH(StackedQueue.stackTwo, deadVal);
                    }
                    deadVal = QSPOP(StackedQueue.stackTwo);
                    QSPUSH(StackedQueue.stackThree, deadVal);
                }
            }

            //put all of stack two into stack three
            //
            //
            //
            // IF STACK THREE IS EMPTY
            //
            //
            //
            else if (StackedQueue.stackThree.Count == 0)
            {
                while (StackedQueue.stackTwo.Count != 0)
                {
                    deadVal = QSPOP(StackedQueue.stackTwo);
                    QSPUSH(StackedQueue.stackThree, deadVal);
                }
            }

            //EITHER WAY pop with dead val.. idk a better name for it 
            deadVal = QSPOP(StackedQueue.stackTwo);
            return deadVal;
        }

        //for popping from a stack
        static int QSPOP(Stack<int> referencedStack)
        {
            //make sure the stack is not empty, if it is emtpy get mad
            if (referencedStack.Count == 0)
            {
                Console.WriteLine("You cannot pop from an empty stack. Please fix this issue and come back. You caused an error...");
            }
            //if it isnt return the pop
            return referencedStack.Pop();
        }


        //When enqueueing check to stacked queue a value push it to stack one always
        static int QSENQUEUE(Queue StackedQueue, int enqueueVal)
        {
            return QSPUSH(StackedQueue.stackOne, enqueueVal);   
        }


        //for pushing to a stack
        static int QSPUSH(Stack<int> referencedStack, int inputVal)
        {
            //just put value into the stack mentioned and return input val
            referencedStack.Push(inputVal);
            return inputVal;
        }
    }
}
