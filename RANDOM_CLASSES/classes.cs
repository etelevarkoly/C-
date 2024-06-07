// DEMO : CLASSES - OBJECTS

using CSharpFundamentals.Math;
// ez a 'using' azért kell, hogy a Calculator. classt 
// meg tudjam itt is hívni.

namespace CSharpFundamentals 
{
    public class Person 
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            System.Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    class Program 
    // régebbi .NET esetében annak a class-nak és Main-nek 
    // is PUBLIC-nak kell lennie, ahol meghívom a public-ként 
    // deklarált függvényemet a public-ként deklarált classban.
    {
        static void Main(string[] args)
        {
            Person jancsi = new Person();
            // var jancsi = new Person();
            jancsi.FirstName = "János";
            jancsi.LastName = "Celergo";

            jancsi.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            // .NET fiddle-n "Calculator.Add" kell, mert 
            // cannot accessed with an instance reference, 
            // use type name instead.
            System.Console.WriteLine(result);
        }
    }
}

/*

RESHARPER:
klikk a class ID-jára és ALT + ENTER, így tudok 
külön FÁJLBA mozgatni instant egy classt.

egy valódi appban van GECISOK class, így célszerű lehet 
külön fájlokba tagolni a classokat.

ha átmozgatok így vagy pedig random "Add" - "New Class" opcióval, 
akkor megjegyzi a NAMESPACE-t és ugyanazt fogja használni.

ha új NAMESPACE-t akarok, akkor érdemes neki ÚJ MAPPÁT 
kreálni és oda gyűjteni a dolgokat.

ha pl csinálok egy Calculator CLASS-t, akkor a NAMESPACE-n belül 
csinálok egy NAMESPACE-t neki:

namespace CSharpFundamentals.Math 

*/