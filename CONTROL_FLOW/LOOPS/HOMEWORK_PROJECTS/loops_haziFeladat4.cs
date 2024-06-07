/*
4- Write a program that picks a random number between 1 and 10. Give 
the user 4 chances to guess the number. If the user guesses the number, 
display “You won"; otherwise, display “You lost". (To make sure the 
program is behaving correctly, you can display the secret number 
on the console first.)
*/

/*
STACKOVERFLOW TURPISSÁG A RANDOM-ra:
The reason is because Random is initialized based on the current time (there 
is no true random in computers... only psuedo-random). The while loop iterates 
too quickly, and the system time has not registered a change. So you're 
re-initializing a new Random object that starts with the same value.
*/

using System;

namespace asd123
{
    class loops_HFXDasd123
    {
        public static string number1Str;
        public static string number2Str;
        public static int number1Int;
        public static int number2Int;
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter number1:");
            number1Str = Console.ReadLine();
            System.Console.WriteLine("enter number2:");
            number2Str = Console.ReadLine();
            try
            {
                number1Int = Convert.ToInt32(number1Str);
                number2Int = Convert.ToInt32(number2Str);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("EXCEPTION; PARSE ERROR; THROW 1");
                throw;
            }

            guesserFunc(number1Int, number2Int);
        }
        public static void guesserFunc(int num1, int num2)
        {
            int choiceRemaining = 4;
            string userGuessStr;
            int userGuessInt;
            var randomClass = new Random();
            var randomNumber = randomClass.Next(num1, num2);
            System.Console.WriteLine("don't read this! the secret number is {0}", randomNumber);

            while (choiceRemaining > 0)
            {
                System.Console.WriteLine("enter your guess:");
                userGuessStr = Console.ReadLine();
                try
                {
                    userGuessInt = Convert.ToInt32(userGuessStr);    
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("INVALID_GUESS; EXCEPTION; PARSE ERROR; THROW 1");
                    throw;
                }
                if (userGuessInt == randomNumber)
                {
                    System.Console.WriteLine("GG, you nailed it!");
                    break;  
                }
                else 
                {
                    choiceRemaining--;
                    if (choiceRemaining == 0)
                    {
                        System.Console.WriteLine("you lost; exiting program.");
                    }
                    else 
                    {
                        System.Console.WriteLine("wrong! your guess was: {0}, choices remaining: {1}", userGuessInt, choiceRemaining);
                    }
                    
                }
                
            }
        }
    }
}