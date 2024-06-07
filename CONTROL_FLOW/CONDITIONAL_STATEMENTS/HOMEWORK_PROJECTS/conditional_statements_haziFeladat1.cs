using System;

namespace HAZIXD 
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("give input between 1 and 10");
            // var userInput = Int32.TryParse((Console.ReadLine()), out int number01);
            // number01 -> kimeneti változó aminek a típusát is meg lehet határozni;
            var userInput = System.Console.ReadLine();
            try
            {
                int userInputToInt = Convert.ToInt32(userInput);    
                giveInput(userInputToInt);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("cannot parse\nTHROWING\n");   
                throw;
            }
        }

        public static void giveInput(int userInput)
        {
            if (userInput >= 1 && userInput <= 10)
            {
                System.Console.WriteLine("VALID_INPUT");
            }
            else 
            {
                System.Console.WriteLine("INVALID_INPUT");
            }
        }

    }   
}