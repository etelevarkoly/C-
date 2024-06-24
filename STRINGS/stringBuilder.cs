using System;
using System.Text;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            
            // .Append(); -> ('char', howManyTimes)
            // mivel ezek a methodok NEM VOID-ok, így a visszaadott érték STRINGBUILDER lesz!
            // így tudom őket chain-callozni anélkül, hogy mindig leírnám a "builder"-t;

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
            // .Remove(); -> (startIndex, length)
            // a startIndex 0 a string első karaktere.
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            System.Console.WriteLine("First Character: " + builder[0]);
            System.Console.WriteLine(builder);
        }
    }
}