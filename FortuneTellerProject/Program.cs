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
            string lasttName = Console.ReadLine();

            
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            
            Console.WriteLine("What is the NUMBER of your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());



            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" and press enter for list of colors");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "Help")
            {
                Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet");
            }

                    

                  
      
























        }
    }
}
