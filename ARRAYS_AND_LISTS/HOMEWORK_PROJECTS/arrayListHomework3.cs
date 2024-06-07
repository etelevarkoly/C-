using System;
using System.Collections.Generic;

/*
3- Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
*/

namespace homeworkdxdxd3
{
    class arrayListHomework3
    {
        static void Main(string[] args)
        {
            
            var numbers = new List<int>();
            var counter = 5;
            string userInputStr;
            int userInputInt;

            while (counter > 0)
            {
                System.Console.WriteLine("enter a number:");    
                userInputStr = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(userInputStr))
                {
                    System.Console.WriteLine("INVALID INPUT; NULL OR WHITESPACE");
                    continue;
                }
                else 
                {
                    try
                    {
                        userInputInt = Convert.ToInt32(userInputStr);
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("INVALID INPUT; EXCEPTION; THROW 1");
                        throw;
                    }
                }

                if (numbers.Contains(userInputInt))
                {
                    System.Console.WriteLine("Error message; {0} already entered; choose another number!", userInputInt);
					continue;
                }
                else 
                {
                    numbers.Add(userInputInt);
                }
                counter--;
            }
            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}