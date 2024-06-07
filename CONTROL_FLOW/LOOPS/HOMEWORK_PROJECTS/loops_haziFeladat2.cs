/*
2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
*/

using System;

namespace haziLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("how many numbers u wanna add?");
            var arrayLength = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("you need to enter {0} numbers\n", arrayLength);
            
            var numArray = new int[arrayLength];
            var indexCounter = 0;
            var total = 0;

            while (true)
            {
                System.Console.Write("enter number or \"ok\" to exit: ");
                var inputStr = Console.ReadLine();
                if (inputStr == "ok")
                {
                    System.Console.WriteLine("EXITING PROGAM");
                    break;
                }
                else if (indexCounter < arrayLength)
                {
                    var inputInt = Convert.ToInt32(inputStr);
                    numArray[indexCounter] = inputInt;
                    indexCounter++;
                    total += inputInt;
                    if (indexCounter == arrayLength)
                    {
                        System.Console.WriteLine("total: " + total);
                        System.Console.WriteLine("array elements: " + string.Join(",", numArray));
                        System.Console.WriteLine("indexCounter :" + indexCounter);
                        break;
                    }
                }
            }
        }
    }
}

/*

// ALTERNATE SOLUTION WITH EXCEPTION HANDLING

using System;

namespace secondHomework
{
    class loopsHomeWork02
    {
        static void Main(string[] args)
        {
            int inputInt;
            string inputStr;
            int total = 0;

            while (true)
            {
                System.Console.WriteLine("enter a number or 'OK' to exit:");
                
                inputStr = Console.ReadLine();
                
                if (inputStr == "OK")
                {
                    System.Console.WriteLine("EXITING;\nSUM_OF_NUMBERS_ENTERED={0}", total);
                    break;
                }
                else 
                {
                    try
                    {
                        inputInt = Convert.ToInt32(inputStr);
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("PARSE ERROR; EXCEPTION; THROW 1");
                        throw;
                    }
                }
                
                total += inputInt;
                
            }
        }
    }
}
*/