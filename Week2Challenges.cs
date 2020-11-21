using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges_ConsoleApp
{
    class Week2Challenges
    {
        static void Main(string[] args)
        {

            // create new instance of GreeterClass called firstGreeting

            GreeterClass firstGreeting = new GreeterClass();

            // get user input (name) to pass to class >>>
            // changed to method 

            firstGreeting.GetFirstName();
            firstGreeting.Name = Console.ReadLine();


            /*   previous way below, changed to method above           
             *   // get user input (name) to pass to class

                         Console.WriteLine("Enter your first name");
                         string firstName = Console.ReadLine();
           */


            // call method Greeting in firstGreeting class, and use user input (name) as string 
            // & write to console our initial greeting


            firstGreeting.Greeting(firstGreeting.Name);

            // set int variable for the hour of the day as now to be used in time of day greeting
            // made internal variable in method
            // int now = DateTime.Now.Hour;

            // call method HourGreeting and use variable in conditional to give time of day greeting

            firstGreeting.HourGreeting();

            // call method Farewell in firstGreeting class, and use user input (name as string
            // & write to console

            firstGreeting.Farewell(firstGreeting.Name);

            Console.ReadLine();

        }
    }
}
