using System;
using System.Collections.Generic;
using System.Linq;

/*
5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list.
*/

namespace homeworkxdxd5
{
    class arrayListHomework5
    {
        static void Main(string[] args)
        {
            for (var i = 2; i > 0; i--)
            {
                System.Console.WriteLine("you have {0} tries left!", i);
                System.Console.WriteLine("enter a list of comma separated numbers (without whitespaces):");
                
                var userInputList = new List<int>();
                string userInputStr;

                userInputStr = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInputStr))
                {
                    System.Console.WriteLine("INPUT CANNOT BE NULL NOR WHITESPACE");
                }
                else
                {
                    try
                    {
                        userInputList = userInputStr.Split(",").Select(int.Parse).ToList();    
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("INVALID INPUT; NOT INT; THROW 3");                        
                        throw;
                    }
                    // test the elements of the list
                    //
                    // foreach (var n in userInputList)
                    // {
                    //     System.Console.WriteLine(n);
                    // }
                }

                if (userInputList.Count < 5 && i == 2)
                {
                    System.Console.WriteLine("ENTER_MORE_NUMBERZ");
                }
                else if (i == 1)
                {
                    System.Console.WriteLine("you lost.");
                    break;
                }
                else 
                {
                    userInputList.Sort();
                    System.Console.WriteLine("the 3 smalles number in the list: {0}, {1}, {2}", userInputList[0], userInputList[1], userInputList[2]);
					break;
                }
            }
        }
    }
}


