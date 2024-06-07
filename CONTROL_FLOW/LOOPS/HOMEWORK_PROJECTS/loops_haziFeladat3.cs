/*
3- Write a program and ask the user to enter a number. Compute the factorial of the 
number and print it on the console. For example, if the user enters 5, 
the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
*/

using System;
using System.Linq;

namespace haziLoops
{
    class Program 
    { 
        static void Main(string[] args)
        {
            System.Console.Write("enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            // reverse is not relevant but never used before :D
            var sequence = Enumerable.Range(1, number).Reverse().ToArray();
            System.Console.WriteLine(string.Join(",", sequence));
            
            var total = sequence[0];
            for (var i = 0; i < sequence.Length - 1; i++)
            {
                total = total * sequence[i + 1];
            }
            System.Console.WriteLine("{0}! equals to {1}", number, total);
        }
    }
}

/*

// ALTERNATE SOLUTION WITHOUT Linq LIB

using System;

namespace loopHW03
{
    class loops_HFXD03
    {
		public static int inputNum;
        static void Main(string[] args)
        {

            System.Console.WriteLine("enter a number:");
            try
            {
                inputNum = Convert.ToInt32(Console.ReadLine());    
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("EXCEPTION; CANNOT PARSE; THROW 1");
                throw;
            }
            
            factorialCalc(inputNum);

        }

        public static void factorialCalc(int num)
        {
            int total = 1;
			for (var i = num; i > 0; i--)
            {
                total = total * i;
				// System.Console.WriteLine("'i' is: {0}; total is: {1}", i, total);
            }
			System.Console.WriteLine("GG, program executed;\n{0}! is equal to {1}", inputNum, total);
        }

    }
}
*/