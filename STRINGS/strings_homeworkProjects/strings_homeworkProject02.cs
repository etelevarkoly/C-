using System;

/*
2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
check to see if there are duplicates. If so, display "Duplicate" on the console.
*/

/*
could be done with Linq namespace:

using System.Linq;

if (testArray.Length != testArray.Distinct().Count())
{
    Console.WriteLine("duplicates");
}
*/

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter numbers separated by a hyphen:");
            string userInputStr = Console.ReadLine();
            var userInputArray = userInputStr.Split('-');

            if (string.IsNullOrWhiteSpace(userInputStr))
            {
                System.Console.WriteLine("no input; exiting");
            }
            else 
            {
                try
                {
                    foreach (var num in userInputArray)
                    {
                        int.Parse(num);
                    }
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("input not INT");
                    throw;
                }
            }

            Array.Sort(userInputArray);
            int previousValue = int.Parse(userInputArray[0]) - 1; // -1 to avoid duplication
            foreach (var number in userInputArray)
            {
                if (int.Parse(number) == previousValue)
                {
                    System.Console.WriteLine("DUPLICATE");
                    break;
                }
                else 
                {
                    previousValue = int.Parse(number);
                }
            }

            System.Console.WriteLine("NO DUPLICATE; SUCCESS;");

        }        
    }
}

