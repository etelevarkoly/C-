using System;

namespace stringz
{
    class stringsDemo
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            // substringet kreál UP TO INDEX, but not including INDEX
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("FirstName: " + firstName);
            System.Console.WriteLine("LastName: " + lastName);
            
            // "names" változó egy STRING ARRAY lesz, mivel a .Split() kimenete egy 
            // string array lesz.
            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: '{0}'; LastName: '{1}'", names[0], names[1]);

            fullName.Replace("Mosh", "Joska");
            fullName.Replace('o', 'X');
            
            // ebből a hosszú és csúnya null or empty meg trimmelős szarból lett 
            // az IsNullOrWhitespace ami NULL + WHITESPACE + EMPTY-t is FIGYEL.
            if (string.IsNullOrEmpty(" ".Trim()))
            {
                System.Console.WriteLine("INVALID");
            }

            // CONVERSION
            var str = "25";
            var age = Convert.ToByte(str); // mivel 255 éves nem lehet xd
            System.Console.WriteLine(age);

            float price = 29.95f;
            // MINDEN OBJEKTUM-nak van .ToString() methodja C#-ban
            System.Console.WriteLine(price.ToString("C"));

            // C0 format specifier kerekíti is a számot!
            System.Console.WriteLine(price.ToString("C0"));
        }
    }
}