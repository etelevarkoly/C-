using System;

namespace arrayNemSzpesz
{
    class Program
    {
        static void Main(string[] args)
        {
            // lehet rövidíteni, hogy nem kell a "new int[]"; hanem csak "new[]"
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // LENGTH
            System.Console.WriteLine("Length: " + numbers.Length);

            // IndexOf() method
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index of 9 is: " + index);

            // Clear() method
            // 0 -> mi az indexe ahonnan töröljön/nullára írja át
            // 2 -> hány DARAB elementet írjon át az array 0-ra.
            // FONTOS, hogy nem az adattípusnak megfelelő DEFAULT értékre írja át, mivel
            // ha ez bool array lenne, FALSE-ra írná át ezeket az értékeket, de ha 
            // pl. string array lenne, akkor NUL-ra írná át.
            Array.Clear(numbers, 0, 2);
            foreach (var element in numbers)
            {
                System.Console.WriteLine(element);
            }

            // Copy() method
            var anotherNumbers = new int[3];
            Array.Copy(numbers, anotherNumbers, 3);
            foreach (var n in anotherNumbers)
            {
                System.Console.WriteLine(n);
            }

            // Sort() method
            Array.Sort(numbers);
            foreach (var k in numbers)
            {
                System.Console.WriteLine(k);
            }

            // Reverse() method
            Array.Reverse(numbers);
            foreach (var x in numbers)
            {
                System.Console.WriteLine(x);
            }

            // a fenti methodok az "Array." classból érhetőek el, mivel STATIC function-ök.
            // ha leírom a CLASS nevét és .-ot ütök, akkor látom a STATIC method-okat.
            // ha leírom az OBJEKTUM nevét ("numbers.") és pontot ütök, akkor azt látom, 
            // ami NEM STATIC, tehát ők INSTANCE MEMBER-ek.

            // Array.Sort() -> meghívható SOK OVERLOADdal; ilyenkor mást csinál a method,
            // pl több paramétert vár ami alapján cselekszik.

            /*
            - SYNTAX for RECTANGULAR 2D:
                var matrix = new int[3, 5];
                var matrix = new int[3, 5]
                {
	                {1,2,3,4,5},
	                {6,7,8,9,10},
	                {11,12,13,14,15},
                };

            - SYNTAX for RECTANGULAR 3D:
            // 2 sor, 2 elem/sor, 3 oszlop
                var colors = new int[2, 2, 3];
                var colors = new int[2, 2, 3]
                {
	                { {1,2,3}, {4,5,6} },
	                { {7,8,9}, {10,11,12} }
                };


            - SYNTAX for JAGGED:
            // példa:
            // 0123
            // 01234
            // 012

            először TOP LEVEL ARRAY-t deklarálunk a sorokat/elementeket megadva:
            var jagged = new int[3][];

            utána pedig minden sor/elementre ÚJABB arrayt deklarálunk:
            jagged[0] = new int[4];
            jagged[1] = new int[5];
            jagged[2] = new int[3];

            elérni egy adott indexét így lehet:
            jagged[0][0] = 1;

            */

        }
    }
}