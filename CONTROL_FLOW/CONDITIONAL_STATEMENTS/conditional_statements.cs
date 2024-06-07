using System;

namespace CSharpFundamentals
{
    // enum-ot külön .cs fájlba rakja a csávó.
    public enum Season 
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("reggelVan");
            }
            else if (hour >= 12 && hour < 18)
            {    
                System.Console.WriteLine("delutan");
            }
            else
            { 
                System.Console.WriteLine("esteVanxd");
            }

            // akkoristegyükki a {} zárójelet ha 1 sor van.
            // mer ez a tuti.

            // CONDITIONAL OPERATOR-ra példa a második:

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else 
            {
                price = 29.95f;
            }
            System.Console.WriteLine(price);

            float zseton = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(zseton);

            // SWITCH / CASE : 
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("its autumn");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("nyar van");
                    break;
                default :
                    System.Console.WriteLine("vszeg tel van");
                    break;
            }

            // ha promóció lenne nyáron és ősszel és nem akarnék 
            // duplikációt hogy cw-vel kiírjam, akkor lehet ilyet:
            // itt VAGY autumn VAGY summer van, akkor irja ki 
            // a promociot.

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("promocio");
                    break;
                default :
                    System.Console.WriteLine("nincsPromocio");
                    break;
            }
            

        }
    }
}