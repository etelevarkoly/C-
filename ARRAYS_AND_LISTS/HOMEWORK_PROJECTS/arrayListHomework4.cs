using System;
using System.Collections.Generic;
using System.Linq;

/*
4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/

namespace asdxdarraylist123
{
    class arrayListHomework4
    {
        static void Main(string[] args)
        {
            string userInputStr;
            int userInputInt;
            var numbers = new List<int>();

            while (true)
            {
                System.Console.WriteLine("enter a number or 'Quit' to exit:");
                userInputStr = Console.ReadLine();

                if (userInputStr == "Quit")
                {
                    System.Console.WriteLine("INITIALIZING PROGRAM SHUTDOWN");
                    sajatProgram(numbers);
                    break;
                }  
                else if (String.IsNullOrWhiteSpace(userInputStr))
                {
                    System.Console.WriteLine("INVALID INPUT; EXITING PROGRAM");
                    break;
                }
                else 
                {
                    try
                    {
                        userInputInt = Convert.ToInt32(userInputStr);
                        numbers.Add(userInputInt);
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("EXCEPTION; INVALID NUMBER; THROW 2");
                        throw;
                    }
                }
            }
        }

        public static void sajatProgram(List<int> numbers)
        {
            System.Console.WriteLine("placeholder");
            // var distinctNumbers = numbers.Distinct();
            // ezekhez kell a 'using System.Linq' namespace; 
            // mind az 'IEnumerable<int>' típushoz, mind a '.Distinct()' methodhoz
            IEnumerable<int> distinctNumbers = numbers.Distinct();
			System.Console.WriteLine(distinctNumbers);
            foreach (var i in distinctNumbers)
            {
                System.Console.WriteLine(i);    
            }
        }
    }
}



