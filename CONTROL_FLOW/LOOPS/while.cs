using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR megoldás
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            // WHILE 
            var i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
                i++;
            }

            // WHILE loop user inputra
            // nem tudjuk hogy a júzer mennyire retardált, 
            // hogy le tudja-e írni a nevét.

            while (true)
            {
                // .Write vs .WriteLine :
                // .Write esetében a villogó "kurzor" nem ugrik 
                // a kövi line-ra, hanem ottmarad.
                System.Console.Write("type ur name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
                
                
                /*
                if (input == "Etele")
                {
                    System.Console.WriteLine("nem vagy retardált\nexiting program");
                    break;
                }
                else 
                {
                    System.Console.WriteLine("retardált vagy\n");
                }
                */
            }

        }
    }
}