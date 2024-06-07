using System;

namespace Operators 
{
    class Program
    {
        // svm -> static void Main(string[] args);
        static void Main(string[] args)
        {
            
            // 1.) ARITHMETIC
            // castolom a két változót, hogy pontos számot kapjak.
            var a = 10;
            var b = 3; 
            System.Console.WriteLine((float)a = (float)b);

            // zárójelek - műveleti sorrend
            var a = 1;
            var b = 2;
            var c = 3;
            System.Console.WriteLine((a + b) * c);

            // 2.) COMPARISON 
            // bool értéket ad vissza.
            var a = 1;
            var b = 2;
            System.Console.WriteLine(a!<b);
            System.Console.WriteLine(a>=);
            
            // az ilyen dupla negálások olvashatatlanok, így 
            // érdemes helyette ==-t használni:
            System.Console.WriteLine(!(a !=b)); // helyett:
            System.Console.WriteLine(a == b);

            // 4.) LOGICAL 
            var a = 1;
            var b = 2;
            var c = 3;
            System.Console.WriteLine(c > b && c == a);
            System.Console.WriteLine(!(c > b || c == a));

        }
    }
}

