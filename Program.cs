using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name.");
            string userName = Console.ReadLine();
            bool again = true;
            while (again)
            {
                Console.WriteLine($"Welcome, {userName} , please enter from 1-100.");
                string input = Console.ReadLine();
                int number = int.Parse(input); //add if statement for this

                if (number % 2 == 0 && number >= 2 && number < 25 || number == 25)
                {
                    Console.WriteLine("Even and less than or equal to 25");

                }
                else if (number % 2 != 0 && number != 60)
                {
                    Console.WriteLine($"Odd, { userName}");
                }
                else if (number % 2 == 0 && number >= 26 && number < 60)
                {
                    Console.WriteLine($"Even, {userName}");
                }
                else if (number % 2 == 0 && number >= 60 && number < 100 || number == 100) 
                {
                    Console.WriteLine($"{number} even, {userName}");
                }
                else if ((number % 2 != 0) && (number >= 60) && (number < 100) || (number == 99))

                {
                    Console.WriteLine($"{number} odd, {userName}");
                }
                else
                {
                    Console.WriteLine($"Please try program again, {userName}");
                    input = Console.ReadLine();
                    number = int.Parse(input);
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                string userchoice = Console.ReadLine().ToLower();
                if (userchoice == "y" || userchoice == "yes")
                {
                    again = true;
                    
                }
                
                else
                {
                    again = false;
                    Console.WriteLine("\nFareWell.");

                }
                
            }
                
        }
    }
}
