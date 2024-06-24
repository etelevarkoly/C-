using System;
using System.Collections.Generic;

namespace stringz
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence);
            System.Console.WriteLine(summary);

            /*
            a "summarisingText.cs" és a "stringUtilityCLASS.cs" összetartozik, együtt alkotnak egy programot.
            a PUBLIC "StringUtility" class és az abban található PUBLIC method felhasználható a program MAIN-jében, 
            mely ebben a "summarisingText.cs" fájlban van.

            mivel NEM void a static method, így RETURN-t kell a végén megadni, melyet egy változóba tudok pakolni az SVM-ben és azt CW-zni.
            */
        }
    }
}