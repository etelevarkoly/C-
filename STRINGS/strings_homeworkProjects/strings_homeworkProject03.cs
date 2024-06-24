using System;

/*
3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
If the user doesn't provide any values, consider it as invalid time.
*/

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter time value in 24-hrs format: HH:MM");
            var userInputStr = Console.ReadLine();
            var userInputDateTime = new DateTime();
            if (string.IsNullOrWhiteSpace(userInputStr))
            {
                System.Console.WriteLine("INVALID TIME; CANNOT BE NULL OR WHITESPACE");
            }
			else if (!userInputStr.Contains(':'))
			{
				Console.WriteLine("input does not contain ':'");
			}
			else
			{
				try
            	{
	                userInputDateTime = DateTime.Parse(userInputStr);    
	            }
	            catch (System.Exception)
	            {
	                System.Console.WriteLine("cannot parse input to dateTime");
	                throw;
	            }
    			Console.WriteLine("user input DateTime: " + userInputDateTime);
			    var startDate = new DateTime(2024, 6, 24, 0, 0, 0);
			    var endDate = new DateTime(2024, 6, 24, 23, 59, 59);
			    Console.WriteLine(startDate);
			    Console.WriteLine(endDate);
				
			    if ((startDate < userInputDateTime) && (endDate > userInputDateTime))
			    {
    				Console.WriteLine("VALID INPUT");
			    }
				else 
				{
					Console.WriteLine("TIME IS NOT BETWEEN 00:00 & 23:59");
				}
			}
        }
    }
}