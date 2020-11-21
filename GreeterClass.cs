using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges_ConsoleApp
{
    class GreeterClass
    {


        /*
        public void GetFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            string firstNameInput = Console.ReadLine();
            string greeting = String.Format("Hello, {0}!", firstNameInput);
            Console.WriteLine(greeting);

        }

        public string GoodBye()
        {
            Console.WriteLine("Good bye " + firstNameInput);

        }

        */


        // set property for username

        public string Name { get; set; }

        // method to write line requesting input, followed up in program w/ firstGreeting.Name = Console.Readline();

        public void GetFirstName()
        {
            Console.WriteLine("Enter your first name:");
        }

        // method to take a string and print it out in a welcome message

        public void Greeting(string firstNameGreeting)
        {
            Console.WriteLine("Hello {0}!", firstNameGreeting);
        }

        // method to take a string and print it in a farewell message

        public void Farewell(string firstNameGreeting)
        {
            Console.WriteLine("Goodbye {0}!", firstNameGreeting);
        }

        // method to take int hour (pulled from DateTime.Now.Hour as 0-24) and run through conditional
        // to print appropriate messge

        public void HourGreeting()
        {
            /* changed ||or conditional to else 
            if ((hour >= 0 && hour < 4) || (hour >= 21 && hour <= 23 ))
            */


            int now = DateTime.Now.Hour;
            if (now >= 4 && now < 12)
            {
                Console.WriteLine("I hope you're having a good morning");
            }
            else if (now >= 12 && now < 17)
            {
                Console.WriteLine("I hope you're having a good afternoon");
            }
            else if (now >= 17 && now < 21)
            {
                Console.WriteLine("I hope you're having a good evening");
            }
            else
            {
                Console.WriteLine("I hope you're having a good night");
            }

            /*
             // comment out to add or || statement in first conditional
            else
            {
                Console.WriteLine("I hope you're having a good night");
            }
            */




        }
    }
}
