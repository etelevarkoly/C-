/*
sokSorosKomment
*/

using System;

namespace TypeConversion 
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMPLICIT
            byte b = 1;
            int i = b;
            System.Console.WriteLine(i);

            // EXPLICIT 
            int n = 1;
            byte k = (byte)n;
            System.Console.WriteLine(k);

            // NON-COMPATIBLE 
            string number = "1234"; // var number = "1234";
            // ez hibára fut -> int m = (int)number; ezért kell ez:
            int m = Convert.ToInt32(number);
            System.Console.WriteLine(m);

            // ez ismét hibára fut, unhandled exception keletkezik:
            var number = "1234";
            byte d = Convert.ToByte(number);
            Console.WriteLine(d);

            // EXCEPTION is .NET framework's error reporting mechanism.
            // TRY - CATCH hibakezelés:
            try
            {
                var number = "1234";
                byte d = Convert.ToByte(number);
                Console.WriteLine(d);    
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("szar vagy öcsém");
            }
            
            // mégegy TRY - CATCH, de itt nincs hiba, mivel 
            // a string - boolean között úgy tűnik lehet váltani.
            try
            {
                string str = "true";
                bool igazHamis = Convert.ToBoolean(str);
                System.Console.WriteLine(igazHamis);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("láma");
            }

        }
    }
}










