using System;

namespace CSharpFundamentals 
{
    public class Person 
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            System.Console.WriteLine(number);
            // a number változó az SVM SCOPE-jában MÁS 
            // memóriahelyen van, mint az Increment(number) 
            // változó, mivel ez VALUE type. így a MAIN-ben 
            // cw-number értéke 1 marad.
            // mikor lefut az Increment(), utána AZONNAL 
            // törlődik a STACK-ből az Increment(number)

            var person = new Person() {Age=20};
            MakeOld(person);
            System.Console.WriteLine(person.Age);
            // a person objektum a PERSON classból van 
            // eredeztetve, így REFERENCE TYPE lesz. 
            // így a cw-person ugyanarra a HEAP-ben lévő 
            // memóriahelyre hivatkozik.
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}