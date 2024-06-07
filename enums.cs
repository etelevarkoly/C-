using System;

namespace CSharpFundamentals 
{
    public enum ShippingMethod 
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            // enum == INTEGER alapból, de valamiért ez ilyen 
            // buzin van megoldva. ha cw-zem a "method"-ot, 
            // "Express" lesz az output, mivel a cw alapból 
            // meghívja a .ToString-et rá, csekkold lent!
            // ha parse-olom int-re, akkor meg 3.
            // ha method.GetType(); -ot futtatok, 
            // akkor meg az output 
            // "CSharpFundamentals.ShippingMethod" lesz.
            // fasz tudja.

            var method = ShippingMethod.Express;
            var methodInt = (int)method;
            System.Console.WriteLine(method);
			System.Console.WriteLine(methodInt);

            // mi van ha kapok vhonnan inputként egy 3-as ID-t?
            var methodID = 3;
            var methodIDtoEnum = (ShippingMethod)methodID;
            System.Console.WriteLine(methodIDtoEnum);
            System.Console.WriteLine(methodIDtoEnum.GetType());

            // enum to string
            // ez szar, nem tudsz így int-et string-gé alakítani:
            // System.Console.WriteLine((string)method);
            
            // ez a jó, minden OBJECT has a ".ToString" metódus:
            System.Console.WriteLine(method.ToString());
            // de AMÚGY a cw MINDEN VALUE-ra amit átadsz neki
            // alapból meghívja rá a ".ToString();"-et, így
            // elhagyható itt például:
            System.Console.WriteLine(method);

            // string to enum 
            var methodName = "Express";
            /* itt jön be a PARSE-olás.
            PARSE -> egy adott STRING-et valami mássá 
            alakítunk. now we PARSE this string to a 
            shipping method.
            we have a CLASS in .NET called "Enum.", which 
            has a static member called ".Parse()":
            Enum.Parse();
            két verziója van ennek a .Parse methodnak 
            amiket OVERLOAD-oknak hívunk.
            1.) TYPE object-et vár. .NET-ben a TYPE egy 
            olyan CLASS, ami METADATA-t tárol más TYPE-okról.
            erre a typeof() függvényt használom, aminek 
            átadom a "ShippingMethod"-ot mint TYPE, illetve a stringet, 
            amit parse-olni akarok. ezt elmentem egy változóba, de ehhez 
            explicit konverzió kell az elejére.
            2.) nem néztük meg.
            */
            var x = (ShippingMethod) Enum.Parse(typeof (ShippingMethod), methodName);

        }
    }
}