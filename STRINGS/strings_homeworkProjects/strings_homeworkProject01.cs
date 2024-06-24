using System;
using System.Text;

/*
1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or 
"20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputStr;
            System.Console.WriteLine("enter a few numbers separated by a hyphen:");
            userInputStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInputStr))
            {
                System.Console.WriteLine("INVALID_INPUT; CANNOT BE NULL OR WHITESPACE");
            }
            else 
            {
                var inputArray = userInputStr.Split('-');
                
                try
                {
                    foreach (var i in inputArray)
                    {
                        int.Parse(i);
                    }
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("INVALID_INPUT; NOT INT");
                    throw;
                }

                // check if array is populated
                // foreach (var i in inputArray)
                // {
                //     System.Console.WriteLine("in array: " + i);
                // }       
                
                // I can sort the string array but then it will always be an increasing sequence
                // Array.Sort(inputArray);
                // foreach (var i in inputArray)
                // {
                //     System.Console.WriteLine("SORTED array: " + i);
                // }

                bool isConsecutive = true;
                int firstNumber = int.Parse(inputArray[0]);
                for (var i = 0; i < inputArray.Length; i++)
                {
                    if (firstNumber != int.Parse(inputArray[i]) - i && firstNumber != int.Parse(inputArray[i]) + i)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                if (isConsecutive == true)
                {
                    System.Console.WriteLine("consecutive");
                }
                else
                {
                    System.Console.WriteLine("not consecutive");
                }
            }
        }
    }
}


