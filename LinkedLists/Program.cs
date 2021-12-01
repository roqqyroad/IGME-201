using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    

    class Program
    { 
        static void Main(string[] args)
        {

            // create a linked list
            LinkedList someEmptyList = new LinkedList();

            LinkedList justOne = new LinkedList();
            justOne.Add(1);

            LinkedList oneAndTwo = new LinkedList();
            oneAndTwo.Add(1);
            oneAndTwo.Add(2);

            LinkedList oneAndTwoAndThree = new LinkedList();
            oneAndTwoAndThree.Add(1);
            oneAndTwoAndThree.Add(2);
            oneAndTwoAndThree.Add(3);
            oneAndTwoAndThree.InsertAt(1, 7);

            string listString = oneAndTwoAndThree.ToString();
            // This will print 3 -> 7 -> 2 -> 1 -> empty
            Console.WriteLine(listString);



            // Test the code you implemented above here.
        }
    }
}
