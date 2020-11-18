using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuperCal()
        {

            //Challenge 1 - foreach
            string Word = "Supercalifragilisticexpialidocious";

            foreach (char letter in Word)
            {
                Console.WriteLine(letter);
            }
        }
          
            //Challenge 2 - declaring variables
        [TestMethod]
        public void NameAndAge()
        {
             string nameFirst = "Shelby";
             string nameLast = "Brown";   
             int age = 24;

                //Chalenge 5 Operators
            Console.WriteLine(age * 7);
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
        }
        
          //Challenge 3 - Array
        [TestMethod]
        public void ListOfMovies()
        {
          
            string[] myMovies = {"Spongebob", "Interstellar", "Frankenstein", "Seinfeld" };

        }

            //Challenge 4 - List

            //use ctrl "." to add a List collection to the namespace?

        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020,12,25));
            listOfDates.Add(new DateTime(2019,12,25));
            listOfDates.Add(new DateTime(2018,12,25));

        }

   
      //Challenge 6 - Conditionals

        [TestMethod]
        public void HowMuchSleepDidYouGet()
             
        {
            Console.WriteLine("How many hours of sleep did you get?");

            int sleepHours = 11;

                if (sleepHours >= 10)
                {
                    Console.WriteLine("Wow! That's a lot of sleep");
                   
                }
                  
                else if (sleepHours >= 8 && sleepHours < 10)
                {
                    Console.WriteLine("You should be well rested");
                }

                else if (sleepHours > 4 && sleepHours < 8)
                {
                    Console.WriteLine("Bummer!");
                }
                else
                {
                   Console.WriteLine("Oh man! Get some sleep!");

                }

        }
            // Challenge 7 - Switch Case

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string dayEval = "Good";

            switch (dayEval) 
            
            {
                case "Great":
                Console.WriteLine("Fantastic!");
                break;

                case "Good":
                    Console.WriteLine("Glad to hear that! Keep it up!");
                    break;

                case "Okay":
                    Console.WriteLine("I hope it gets better");
                    break;

                case "Bad":
                    Console.WriteLine("Have some ice cream.");
                    break;

                default:

                    Console.WriteLine("We hope you're having a nice day!");
                    break;



            }
        }

    }

}
