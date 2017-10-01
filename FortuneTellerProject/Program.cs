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
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                birthMonth = 1000000;
            }
            else if (birthMonth > 4 && birthMonth <= 8)
            {
                birthMonth = 20;
            }
            else
            {
                birthMonth = 65000;
            }






            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" and press enter for list of colors");
            string favoriteColor = Console.ReadLine();
            if (favoriteColor == "Help")
            {
                Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet");
            }
            else favoriteColor = (Console.ReadLine());






            Console.WriteLine("How many siblings do you have?");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("Final chance to turn back. You could be doomed...Press \"enter\" for fortune");
            Console.ReadLine();


            Console.WriteLine(firstName + " " + lastName + " " + "will retire in" + " " + age + "years" + " " + "with" + " " + birthMonth + " " + "dollars in the bank");



























        }
    }
}
