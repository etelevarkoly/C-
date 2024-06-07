using System;

namespace kutya 
{
    class Program 
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("give a number:");
            var number1String = Console.ReadLine();
            System.Console.WriteLine("give another:");
            var number2String = Console.ReadLine();

            var number1Int = Convert.ToInt32(number1String);
            var number2Int = Convert.ToInt32(number2String);

            if (number1Int > number2Int)
            {
                System.Console.WriteLine("a nagyobb szam: {0}", number1Int);
            }
            else 
            {
                System.Console.WriteLine("a nagyobb szam: " + number2Int);
            }

            // használhatnék egy külön változót a legnagyobb 
            // számra és akkor az IF / ELSE inicializálná azt, 
            // akkor csak egy cw kellene hogy ezt a változót kiírjam.

            // az összehasonlítást vélhetően át kellene rakni 
            // egy külön function-be, amit csak meg kell hívjak 
            // a MAIN-ben.

            // nincs hibakezelés.

        }
    }
}

/*
ALTERNATE SOLUTION

using System;

namespace HF02 
{
    class HFXD
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter 2 numbers:");
            // var userInput01 = Int32.TryParse((Console.ReadLine()), out int userIntInput01);
            
            try
            {
                var userInput01 = Convert.ToInt32(Console.ReadLine());
                var userInput02 = Convert.ToInt32(Console.ReadLine());
                melyikNagyobb(userInput01, userInput02);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("EXCEPTION; THROWING");
                throw;
            }
            
        }

        public static void melyikNagyobb(int a, int b)
        {
            if (a > b)
            {
                System.Console.WriteLine("{0} is bigger", a);
            }
            else 
            {
                System.Console.WriteLine("{0} is bigger", b);
            }
        }
    }
}
*/