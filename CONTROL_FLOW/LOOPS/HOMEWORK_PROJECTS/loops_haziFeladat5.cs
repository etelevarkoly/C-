/*
5- Write a program and ask the user to enter a series of numbers 
separated by comma. Find the maximum of the numbers and display it on 
the console. For example, if the user enters “5, 3, 8, 1, 4", 
the program should display 8.
*/

using System;
using System.Linq;

namespace haziLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter a series of numbers sparated by comma: ");
            var inputStr = Console.ReadLine();
            int[] inputArray = inputStr.Split(",").Select(int.Parse).ToArray();
            System.Console.WriteLine("max value of the array: {0}", inputArray.Max());
        }
    }
}

/*

ALTERNATE SOLUTION

using System;
using System.Linq;

namespace loopsHaziXD123
{
    class loopsHazixD4321
    {
        static void Main(string[] args)
        {

            string arrayLengthStr;
            int arrayLenghtInt;
            System.Console.WriteLine("enter how many numbers would you like to use:");
            arrayLengthStr = Console.ReadLine();
            try
            {
                arrayLenghtInt = Convert.ToInt32(arrayLengthStr);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("EXCEPTION; PARSE ERROR; THROW 1");
                throw;
            }
            
            System.Console.WriteLine("enter {0} numbers separated by commas:", arrayLenghtInt);

            var arrayStr = Console.ReadLine();
            System.Console.WriteLine("arrayStr equals to [{0}]", arrayStr);

            int[] arrayInt = arrayStr.Split(",").Select(int.Parse).ToArray();
            
            int highestNum = 0;
            // start checking from the last element, because user
            // probably sets the last element as the highest
            for (var i = arrayLenghtInt; i > 0; i--)
            {
                if (arrayInt[i-1] > highestNum)
                {
                    highestNum = arrayInt[i-1];
                    System.Console.WriteLine(highestNum);
                }
                else 
                {
                    continue;
                }
            }

            System.Console.WriteLine("highest number is {0}", highestNum);
            
        }


    }
}
*/