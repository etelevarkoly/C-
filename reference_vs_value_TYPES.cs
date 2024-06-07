using System;

namespace CSharpFundamentals 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // ha egy VALUE TYPE-ot egy másik 
            // változóba másolok, akkor átmásolja a 
            // változó ÉRTÉKÉT a target változóba a memóriában.
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a : {0} b : {1}", a, b));

            // array2 olyan, mint egy pointer, REFERENCES 
            // az array1-re, így a HEAPben csak 1x lesz tárolva 
            // az adott ARRAY.
            // ha bármelyik tömbben változtatok
            // a másikban is változik, mivel ugyanarra a 
            // memóriacímre mutatnak.
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }
    }
}