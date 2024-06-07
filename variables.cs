// komment 

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberByte = 1;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            // CHAR-nál aposztróf kell;
            // STRING-nél IDÉZŐJEL kell;
            bool isWorking = false;
            
            Console.WriteLine(numberByte);

            // cw + TAB shortcut:
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            // változókat 'var'-ral is lehet deklarálni,
            // akkor a C# COMPILER dönti el, hogy az 
            // milyen adattípus.
            var randomSzam = 255;
            System.Console.WriteLine(randomSzam);
            // sajnos minden számra INT-et használ xd
            // csávó szerint MAJDNEMMINDIG INT-et használunk.

            // CTRL + CLICK valamire és felhozza a 
            // VS object browsert. itt látni, hogy milyen 
            // objektum tartozik mihez.

            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            /*
            {0} {1} == FORMAT STRING 
            egyfajta template-ként lehet használni. 
            nulla és 1 lesz az argumentum és felveszi azokat az 
            értékeket, amiket utána adok meg min és maxValue-val.
            
            FORMAT STRING esetében mindig kapcsos zárójellel 
            adom ezt meg.

            nem találtam infót, hogy hány argument lehet a 
            format stringben.
            */

            const float Pi = 3.14f;

        }
    }
}