/*
1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
*/

// this program gets the input from the user

using System;

namespace Name
{
    class DivNum
    {
        static void Main(string[] args)
        {
			
			int number1;
        	int number2;
        	int divNum;
			int counter = 0;
			
			try
            {
                System.Console.Write("enter number1:");
                number1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("enter number2:");
                number2 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("enter number to divisible by:");
                divNum = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("PARSE ERROR; EXCEPTION; THROW 1");
                throw;
            }
			
			remainderDivFunc(number1, number2, divNum, counter);
			
        }

        public static void remainderDivFunc(int num1, int num2, int div, int count)
        {
            var counter = 0;
			for (var i = num1; num1 <= num2; num1++)
			{
				if (num1 % div == 0)
				{
					counter++;
					// Console.WriteLine("number: {0}, counter: {1}", num1, counter);
				}
				else 
				{
					continue;
				}
			}
            
			Console.WriteLine("there were {0} numbers which are divisible by {1} with no remainder", counter, div);
        }
    }
}