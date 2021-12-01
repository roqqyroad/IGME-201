using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    /* 
     * QUESTION SEVEN 
     * converting to classes and interfaces 
     */
    
        /* INTERFACES */
       public interface IDrivable{
         bool Drive(bool isDriving);
       }
       
      public interface ITeam
      {
        string RecruitTeammate(string recruitName);
        string Demonstrate(string location);
        int Compete(int placement);
      }

    
    public interface IHumanity
    {
        string Eat(string foodAte);
        int Sleep(int timeSlept);
    }
    class RobotTeam : Subteams, ITeam
    {

        string TeamName;
        int TeamNumber;

        string[] TeamList;
        int teamListSlot = 0;

        object mentor = new Mentor();

        public string RecruitTeammate(string recruitName)
        {
            string teammate = recruitName;
            return teammate;
            TeamList[teamListSlot] = teammate;
            teamListSlot++;
        }

        public string Demonstrate(string location)
        {
            string demonstratedAt = location;
            return demonstratedAt;
        }
        public int Compete(int placement)
        {
            int compResults = placement;
            return compResults;
        }

      
    }
    
    class Human : IHumanity
    {
        string name;
        int age;

        public string Eat(string foodAte) 
        {
            return foodAte;
        }
        public int Sleep(int timeSlept) 
        {
            return timeSlept;
        }
    }

    class Member : Human 
    { 
        public string Eat(string foodAte)
        { 
            if(foodAte != "Pizza") {
                Console.WriteLine("You shoulda brought pizza...");
            }
            else
            {
                Console.WriteLine("Wow you brought pizza...");
            }
            return foodAte;
        }
        public int Sleep(int timeSlept)
        {
            timeSlept = 0;
            Console.WriteLine("Members of a team are students, students don't sleep.");
            return timeSlept;
        }

        public string HumanResponse(object obj)
        {
            
            if (obj == typeof(Human))
            {
                Console.WriteLine("I guess I probably am human? Just no sleep...");
            }
            else
            {
                Console.WriteLine("I'm a robot??");
            }
            return "";
        }
    }
    class Mentor : Human 
    {
        string job;
        public string talk()
        {
            Console.WriteLine("I work as " + job);
            return job;
        }

        public string HumanResponse(object obj)
        {
            if (obj == typeof(Human))
            {
                Console.WriteLine("I can assure you I am not the robot here..");
            }
            else
            {
                Console.WriteLine("I usppose I must be a robot");
            }
            
            return "";
        }

    }

    class Subteams
    {
        class Mechanical { }
        class Electrical { }
        class Programming { }
        class Marketing { }
    }

    class Robot : IDrivable
    {
        public bool Drive(bool isDriving ){
            bool drive = isDriving;
            return drive; 
        }
    }

 
    
    class Program
    {

        object kid = new Member();
        object adult = new Mentor();

        HumanResponse(adult);
        HumanResponse(kid);
        //Not quite sure I understand how to do this, even after looking for explinations as to how this works...
        static void Main(string[] args)
        {

        }
    }
}
