using System;

namespace StructToClass
{

    //I'm aware this isn't functional, I saved this question to do last and have a migraine as I am doing this and cant quite process what's wrong as a result of that. 
    //It's about five minutes before due date, hence this question not being done properly really. 
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend;
            Friend enemy = new Friend;

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}

