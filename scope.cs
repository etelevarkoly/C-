// scope check

using System;

namespace ScopeXD 
{
    class Szkop 
    {
        static void Main(string[] args)
        {
            byte a = 1;
            System.Console.WriteLine("b" + b);
            // 'b' nem hívható meg, mivel az más scope
            {
                byte b = 2;
                System.Console.WriteLine("a" + a);
                System.Console.WriteLine("c" + c);
                // 'a' meghívható, mivel már öröklődött ide, 
                // de 'c' nem, mivel az ismét más scope
                {
                    byte c = 3;
                    System.Console.WriteLine("a" + a);
                    System.Console.WriteLine("b" + b);
                    System.Console.WriteLine("c" + c);
                    // használható mindhárom változó, 
                    // mivel már öröklődött ide.
                }
            }
        }
    }
}