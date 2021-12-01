using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions4And5
{
    /* INTERFACES */
     public interface IDialable : PushButtonPhone
    {
        public void Answer();
        public void MakeCall();
        public void HangUp();
    }

    public interface ITimeMachine
    {
        public void TimeTravel();
    }

    /* CLASSES */

    abstract class Phone
    { 
        public string phoneNumber;
        public void Connect();
        public void Disconnect();
        static void Dial(IDialable phone, string person);
    }

    class RotaryPhone : Phone, IDialable { }

    public class PushButtonPhone : Phone, IDialable { }

    public class Tardis : ITimeMachine
    {
        public Boolean sonicScrewdriver;
        public string sidekick;

        object tardisPhone = new RotaryPhone;
    }

    

    class Program
    {

        /*
         * is-a (plain arrow between rectangles)
         * has-a (labeled arrow)
         * can-be or can-do (circle with arrow)
        */
        static void Main(string[] args)
        {

            object tardis = new Tardis;
            object pushPhone = new PushButtonPhone;
           

            pushPhone.Dial(tardis, "doctor");
            pushPhone.MakeCall();
            pushPhone.HangUp();


        }
    }
}
