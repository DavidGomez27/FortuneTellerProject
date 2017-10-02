using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. I will provide your fortune today based on the answers you provide. Press \"enter\" to continue");
            Console.ReadLine();


            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();



            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();


            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                age = 50;
            }
            else age = 5;



            Console.WriteLine("What is the NUMBER of your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());
            string moneySaved;

            if (birthMonth >= 1 && birthMonth <= 4)

           {
                moneySaved = "$,1000,000";
            }
            else if (birthMonth > 4 && birthMonth <= 8)
            {
                moneySaved = "$20";
            }
            else
            {
                moneySaved = "$65,000";
            }





            //Could not get my "help" option to register color after using help so used work around of repeating the question for the user.
            Console.WriteLine("What is your favorite ROYGBIV color? Type \"help\" and press enter for list of colors");
            string favoriteColor = (Console.ReadLine().ToLower());
            if (favoriteColor == "help")
                
            {
                Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet. Press \"enter\" to continue and imput your favorite color.");
                favoriteColor = (Console.ReadLine().ToLower());
                Console.WriteLine("What is your favorite ROYGBIV color?");
                favoriteColor = (Console.ReadLine().ToLower());
            }
            
            
            if (favoriteColor == "red")
            {
                favoriteColor = "Aston Martin";
            }
            else if (favoriteColor == "orange")
            {
                favoriteColor = "Scooter";
            }
            else if (favoriteColor == "yellow")
            {
                favoriteColor = "unicycle";
            }
            else if (favoriteColor == "green")
            {
                favoriteColor = "dog sled";
            }
            else if (favoriteColor == "blue")
            {
                favoriteColor = "Patty Wagon";
            }
            else if (favoriteColor == "Indigo")
            {
                favoriteColor = "dolphin with a saddle";
            }
            else
            {
                favoriteColor = "hot air balloon";
            }







            Console.WriteLine("How many siblings do you have?");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            string vacationHome;
            if (numberOfSiblings == 0)
            {
                vacationHome = "el Dorado,";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "Phantom Zone,";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "Maldives,";
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "Belize,";
            }
            else
            {
                vacationHome = "8 mile Detroit,";
            }



            Console.WriteLine("Final chance to turn back. You could be doomed...Press \"enter\" for fortune");
            Console.ReadLine();


            Console.WriteLine(firstName + " " + lastName + " " + "will retire in" + " " + age + " " + "years" + " " + "with" + " " + moneySaved + " " + "dollars in the bank,");
            Console.WriteLine("a vacation home in" + " " + vacationHome + " " + "and a" + " " + favoriteColor);


























        }
    }
}
