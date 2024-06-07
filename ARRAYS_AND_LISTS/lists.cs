using System;
using System.Collections.Generic;
// ez kell, mivel GENERIC TYPE-ot használok lejjebb, azaz LIST-et.

namespace lists
{
    class listsProgram
    {
        static void Main(string[] args)
        {
            /*
            SYNTAX:
            var numbers = new List<int>();
            var numbers = new List<int>(){1,2,3,4,5};
            */

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);

            // .AddRange() -> overloadnál látom, hogy "IEnumerable" van írva a paraméterezéshez.
            // ha "I" van valami előtt, akkor az "Interface"-t jelent.
            // ilyenkor használhatok ARRAY-t vagy LIST-et mint paraméter.
            numbers.AddRange(new int[3] { 3, 6, 7 });

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            // IndexOf() method
            System.Console.WriteLine("IndexOf 1: " + numbers.IndexOf(1));

            // LastIndexOf() method
            // lista VÉGÉRŐL kezdi el keresni az elementet
            System.Console.WriteLine("LastIndexOf 1: " + numbers.LastIndexOf(1));

            // Count PROPERTY
            // number of elements/objects in the list
            System.Console.WriteLine("Count of numbers:" + numbers.Count);

            // Remove() method
            numbers.Remove(1);
            
            // ERRE ELSZÁLL, mivel FOREACH loopban NEM változtathatunk a
            // collection elemein.
            /*
            foreach (var n in numbers)
            {
                if (n == 1)
                {
                    numbers.Remove(n);
                }
            }
            */

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Clear() method
            numbers.Clear();
            System.Console.WriteLine("new count of numbers after Clear(); -> " + numbers.Count);

        }
    }
}