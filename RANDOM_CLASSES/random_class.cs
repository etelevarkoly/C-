using System;

namespace CSharpFundamentals 
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
                       
            // random.NextBytes() -> fills the elements of a specified 
            // array of bytes with random numbers.

            // random.NextDouble() -> returns a random number 
            // between 0.0 and 1.0

            // random.Next() -> returns a nonNegative random number.
            // random.Next(10) -> maxValue-t adok meg.
            // random.Next(1, 10) -> minValue, maxValue-t adok meg.
            
            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1, 10));
            }
            
            // tudom CAST-olni a CHAR adattípust INT32-vé, 
            // ami lehetőséget nyújt hogy egy generált 
            // INT32 arrayből PASSWORD-öt generáljak.
            // American Standard Code for Information Interchange
            // ASCII (American Standard Code for Information Interchange) is 
            // the most common character encoding format for text data in 
            // computers and on the internet. In standard ASCII-encoded data, 
            // there are unique values for 128 alphabetic, numeric or special 
            // additional characters and control codes.
            // https://www.ascii-code.com/

            System.Console.WriteLine((int)'a');
            // ezzel csak az a baj, hogy ha vki ránéz, fingja nem lesz, 
            // hogy mi ez a 97 meg 122 xd
            for (var i = 0; i < 10; i++)
            {
                System.Console.Write((char)random.Next(97, 122));
            }
            System.Console.WriteLine();

            // így érthetőbb lesz, hogy mit akarok csinálni.
            // az 'a' értéke 97 amihez hozzáadom a generált számokat.
            for (var i = 0; i < 10; i++)
            {
                System.Console.Write((char)('a' + random.Next(0, 26)));
            }
            System.Console.WriteLine();

            // az így generált "jelszó" string nem teljesen lesz jó nekem, 
            // mivel a STRING IMMUTABLE; ezért kell nekem egy CHAR ARRAY erre.

            // nem égetünk bele string-eket a kódba, változót használunk 
            // as an improvement.

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)('a' + random.Next(0, 26)));
            }
            
            // mivel a STRING egy class, csinálhatok belőle 
            // OBJECT/INSTANCE-ot, így OVERLOAD-okat tudok használni rá.
            var password = new string(buffer);

            System.Console.WriteLine(password);

        }
    }
}